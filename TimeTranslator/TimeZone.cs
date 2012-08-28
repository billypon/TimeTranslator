#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

#endregion

namespace TimeTranslator
{
	internal class TimeZone : IComparable<TimeZone>
	{
		public static readonly TimeZone defaultZone = new TimeZone{
		                                                          	Text = "+08:00",
		                                                          	Type = ZoneType.Plus,
		                                                          	Hour = 8,
		                                                          	Minute = 0,
		                                                          	Symbol = '+'
		                                                          };

		public enum ZoneType
		{
			Minus,
			Noting,
			Plus
		}

		public string Text;
		public ZoneType Type;
		public int Hour;
		public int Minute;
		public char Symbol;

		public TimeSpan GetDiff(TimeZone other)
		{
			return GetDiff(this, other);
		}

		public TimeSpan GetDiffTimeSpan(TimeZone other) { return GetDiffTimeSpan(this, other); }

		public int CompareTo(TimeZone other)
		{
			if (this.Type == other.Type)
			{
				if (this.Hour == other.Hour)
				{
					return this.Minute.CompareTo(other.Minute);
				}
				else
				{
					return this.Hour.CompareTo(other.Hour);
				}
			}
			else
			{
				return ((int)this.Type).CompareTo((int)other.Type);
			}
		}

		public override string ToString() { return this.Text; }

		public static TimeSpan GetDiff(TimeZone zone1, TimeZone zone2)
		{
			int compare = zone1.CompareTo(zone2);
			if (compare == 0)
				return new TimeSpan();
			int type1 = (int)zone1.Type;
			int type2 = (int)zone2.Type;
			TimeSpan ts1 = new TimeSpan(zone1.Hour, zone1.Minute, 0);
			TimeSpan ts2 = new TimeSpan(zone2.Hour, zone2.Minute, 0);
			long t1 = ts1.Ticks;
			long t2 = ts2.Ticks;
			long tick;
			if (type1 != type2)
			{
				tick = t1 + t2;
			}
			else if (compare > 0)
			{
				tick = t1 - t2;
			}
			else
			{
				tick = t2 - t1;
			}
			return new TimeSpan(tick);
		}

		/// <summary>
		/// </summary>
		/// <param name = "source"></param>
		/// <param name = "destination"></param>
		/// <returns></returns>
		/// <!--由于当source比destination小时，从source到destination需要增加时间，反过来时需要扣除时间，所以这里的正负号是反过来的-->
		public static TimeSpan GetDiffTimeSpan(TimeZone source, TimeZone destination)
		{
			int compare = source.CompareTo(destination);
			if (compare == 0)
				return new TimeSpan();
			else if (compare < 0)
				return GetDiff(source, destination);
			else
				return new TimeSpan(GetDiff(source, destination).Ticks * -1);
		}

		public static List<List<TimeZone>> GetTimeZoneFromXml(string filename)
		{
			if (!File.Exists(filename))
			{
				throw new FileNotFoundException();
			}
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(filename);

			List<TimeZone> defaults = null;
			XmlNode xmlNode = xmlDoc.SelectSingleNode("/TimeZone/Default");
			if (xmlNode != null)
			{
				XmlElement xmlDefault = (XmlElement)xmlNode;
				XmlNodeList items = xmlDefault.SelectNodes("Item");
				GetItemConfig(out defaults, items);
			}

			List<TimeZone> customs = null;
			xmlNode = xmlDoc.SelectSingleNode("/TimeZone/Custom");
			if (xmlNode != null)
			{
				XmlElement xmlCustom = (XmlElement)xmlNode;
				XmlNodeList items = xmlCustom.SelectNodes("Item");
				GetItemConfig(out customs, items);
			}

			List<List<TimeZone>> list = new List<List<TimeZone>>(2){
			                                                       	defaults,
			                                                       	customs
			                                                       };
			return list;
		}

		private static void GetItemConfig(out List<TimeZone> list, XmlNodeList items)
		{
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			else
			{
				list = new List<TimeZone>(items.Count);
				foreach (XmlNode item in items)
				{
					XmlElement element = (XmlElement)item;
					ZoneType type = ZoneType.Noting;
					int hour = 0, minute = 0;
					char symbol = ' ';
					XmlAttribute attribute = element.Attributes["symbol"];
					if (attribute == null || attribute.Value.Length == 0)
					{
						ThrowXmlAttributeException("symbol");
					}
					else
					{
						switch (attribute.Value)
						{
							case " ":
								type = ZoneType.Noting;
								symbol = ' ';
								break;
							case "-":
								type = ZoneType.Minus;
								symbol = '-';
								break;
							case
								"+":
								type = ZoneType.Plus;
								symbol = '+';
								break;
							default:
								ThrowXmlAttributeException("symbol");
								break;
						}
					}
					attribute = element.Attributes["hour"];
					int _hour;
					if (!int.TryParse(attribute.Value, out _hour))
					{
						ThrowXmlAttributeException("hour");
					}
					else
					{
						hour = _hour;
					}
					attribute = element.Attributes["minute"];
					int _minute;
					if (!int.TryParse(attribute.Value, out _minute))
					{
						ThrowXmlAttributeException("minute");
					}
					else
					{
						minute = _minute;
					}
					attribute = element.Attributes["text"];
					string text = attribute == null || attribute.Value.Length == 0
					              	? string.Format("{0}{1:d2}:{2:d2}", symbol, hour, minute)
					              	: attribute.Value;
					TimeZone zone = new TimeZone{
					                            	Text = text,
					                            	Type = type,
					                            	Hour = hour,
					                            	Minute = minute,
					                            	Symbol = symbol
					                            };
					list.Add(zone);
				}
			}
		}

		private static void ThrowXmlAttributeException(string attributeName) { throw new XmlException(string.Format("找不到 {0} 属性或属性值无效！", attributeName)); }
	}
}