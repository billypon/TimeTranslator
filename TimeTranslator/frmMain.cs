#region

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#endregion

namespace TimeTranslator
{
	public partial class frmMain : Form
	{
		private const string TextBoxDefault = "hh:mm";
		private List<TimeZone> listDefault, listCustom;
		public frmMain() { InitializeComponent(); }

		private void frmMain_Load(object sender, EventArgs e)
		{
			List<List<TimeZone>> list = TimeZone.GetTimeZoneFromXml("TimeZone.xml");
			listDefault = list[0];
			listCustom = list[1];
			foreach (TimeZone zone in listDefault)
				cbTimeZone.Items.Add(zone);
			foreach (TimeZone zone in listCustom)
				cbCustomZone.Items.Add(zone);
			cbTransType.SelectedIndex = cbTimeZone.SelectedIndex = 0;
			if (cbCustomZone.Items.Count != 0)
				cbCustomZone.SelectedIndex = 0;
			cbTimeType.SelectedIndex = 1;
			dtpMain.Value = DateTime.Today;

			cbTimeZone.Focus();
		}

		private void cbTimeZone_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbTimeZone.SelectedIndex == 1)
			{
				flpMain.SetFlowBreak(cbTimeZone, false);
				cbCustomZone.Visible = true;
			}
			else
			{
				flpMain.SetFlowBreak(cbTimeZone, true);
				cbCustomZone.Visible = false;
			}
		}

		private void cbTimeType_SelectedIndexChanged(object sender, EventArgs e) { dtpMain.Visible = cbTimeType.SelectedIndex != 0; }

		private void txtTime_Enter(object sender, EventArgs e)
		{
			if (txtTime.Text == TextBoxDefault)
			{
				txtTime.Text = string.Empty;
				txtTime.ForeColor = SystemColors.WindowText;
			}
			else
			{
				txtTime.SelectAll();
			}
		}

		private void txtTime_Leave(object sender, EventArgs e)
		{
			if (txtTime.Text.Length == 0)
			{
				txtTime.Text = TextBoxDefault;
				txtTime.ForeColor = SystemColors.GrayText;
			}
		}

		private void btnTrans_Click(object sender, EventArgs e)
		{
			bool bContinue = true;
			if (cbTimeZone.SelectedIndex > 1)
			{
				cbTimeZone.BackColor = SystemColors.Window;
			}
			else if (cbTimeZone.SelectedIndex == 1)
			{
				cbTimeZone.BackColor = SystemColors.Window;
				if (cbCustomZone.SelectedIndex < 0)
				{
					cbCustomZone.BackColor = Color.Yellow;
					bContinue = false;
				}
				else
				{
					cbCustomZone.BackColor = SystemColors.Window;
				}
			}
			else
			{
				cbTimeZone.BackColor = Color.Yellow;
				bContinue = false;
			}
			int hour = 0, minute = 0;
			if (txtTime.Text == TextBoxDefault)
			{
				txtTime.BackColor = Color.Yellow;
				bContinue = false;
			}
			else
			{
				Match match = Regex.Match(txtTime.Text, @"^(\d+):(\d+)$");
				if (match.Success)
				{
					hour = int.Parse(match.Groups[1].Value);
					minute = int.Parse(match.Groups[2].Value);
					txtTime.BackColor = SystemColors.Window;
					if (hour > 23 || minute > 59)
					{
						txtTime.BackColor = Color.Red;
						bContinue = false;
					}
				}
				else
				{
					txtTime.BackColor = Color.Red;
					bContinue = false;
				}
			}
			if (bContinue)
			{
				TimeZone zone = (TimeZone)(cbTimeZone.SelectedIndex > 1 ? cbTimeZone.SelectedItem : cbCustomZone.SelectedItem);
				TimeSpan diff;
				string text;
				if (cbTransType.SelectedIndex == 0)
				{
					// 转换至
					diff = TimeZone.GetDiffTimeSpan(TimeZone.defaultZone, zone);
					text = "当地时间：\n";
				}
				else
				{
					// 转换自
					diff = TimeZone.GetDiffTimeSpan(zone, TimeZone.defaultZone);
					text = "本地时间：\n";
				}
				if (cbTimeType.SelectedIndex == 1)
				{
					TimeSpan time = new TimeSpan(hour, minute, 0);
					text += (new DateTime(dtpMain.Value.Ticks + time.Ticks)).Add(diff).ToString("yyyy-MM-dd HH:mm");
				}
				else
				{
					TimeSpan time = new TimeSpan(1,hour, minute, 0);
					DateTime t1 = new DateTime(time.Ticks);
					DateTime t2 = t1.Add(diff);
					text = t2.ToString("HH:mm");
					if (t1.Date < t2.Date)
						text += "(后一天)";
					else if (t1.Date > t2.Date)
						text += "(前一天)";
				}
				MessageBox.Show(text, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnNow_Click(object sender, EventArgs e)
		{
			dtpMain.Value = DateTime.Today;
			txtTime.Text = DateTime.Now.ToString("HH:mm");
			txtTime.ForeColor = SystemColors.WindowText;
		}

		private void cbTransType_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = "";
			switch(cbTransType.SelectedIndex)
			{
				case 0:
					text = "转换为当地时间";
					break;
				case 1:
					text = "转换为本地时间";
					break;
			}
			lblTips.Text = text;
		}
	}
}