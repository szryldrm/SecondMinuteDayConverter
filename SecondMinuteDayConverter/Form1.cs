// ***********************************************************************
// Assembly         : SecondMinuteDayConverter
// Author           : SezerYildirim
// Created          : 03-05-2017
//
// Last Modified By : SezerYildirim
// Last Modified On : 03-07-2017
// ***********************************************************************
// <copyright file="Form1.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondMinuteDayConverter {
    /// <summary>
    /// Class Form1.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// Create New Class From converters
        /// </summary>
        converters cnv = new converters();

        /// <summary>
        /// Convert Button's Click Events.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnConvert_Click(object sender, EventArgs e) {
            try {
                lblResult.ForeColor = Color.Black;
                if (rdnSecond.Checked && rdnMinute2.Checked) {
                    lblResult.Text = cnv.secondToMinute(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Minutes";
                }
                else if (rdnSecond.Checked && rdnHour2.Checked) {
                    lblResult.Text = cnv.secondToHour(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Hours";
                }
                else if (rdnSecond.Checked && rdnDay2.Checked) {
                    lblResult.Text = cnv.secondToDay(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Days";
                }
                else if (rdnSecond.Checked && rdnWeek2.Checked) {
                    lblResult.Text = cnv.secondToWeek(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Weeks";
                }
                else if (rdnSecond.Checked && rdnMonth2.Checked) {
                    lblResult.Text = cnv.secondToMonth(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Months";
                }
                else if (rdnSecond.Checked && rdnYear2.Checked) {
                    lblResult.Text = cnv.secondToYear(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Years";
                }

                else if (rdnMinute.Checked && rdnSecond2.Checked) {
                    lblResult.Text = cnv.minuteToSecond(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Seconds";
                }
                else if (rdnMinute.Checked && rdnHour2.Checked) {
                    lblResult.Text = cnv.minuteToHour(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Hours";
                }
                else if (rdnMinute.Checked && rdnDay2.Checked) {
                    lblResult.Text = cnv.minuteToDay(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Days";
                }
                else if (rdnMinute.Checked && rdnWeek2.Checked) {
                    lblResult.Text = cnv.minuteToWeek(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Weeks";
                }
                else if (rdnMinute.Checked && rdnMonth2.Checked) {
                    lblResult.Text = cnv.minuteToMonth(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Months";
                }
                else if (rdnMinute.Checked && rdnYear2.Checked) {
                    lblResult.Text = cnv.minuteToYear(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Years";
                }

                else if (rdnHour.Checked && rdnSecond2.Checked) {
                    lblResult.Text = cnv.hourToSecond(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Seconds";
                }
                else if (rdnHour.Checked && rdnMinute2.Checked) {
                    lblResult.Text = cnv.hourToMinute(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Minutes";
                }
                else if (rdnHour.Checked && rdnDay2.Checked) {
                    lblResult.Text = cnv.hourToDay(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Days";
                }
                else if (rdnHour.Checked && rdnWeek2.Checked) {
                    lblResult.Text = cnv.hourToWeek(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Weeks";
                }
                else if (rdnHour.Checked && rdnMonth2.Checked) {
                    lblResult.Text = cnv.hourToMonth(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Months";
                }
                else if (rdnHour.Checked && rdnYear2.Checked) {
                    lblResult.Text = cnv.hourToYear(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Years";
                }

                else if (rdnDay.Checked && rdnSecond2.Checked) {
                    lblResult.Text = cnv.dayToSecond(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Seconds";
                }
                else if (rdnDay.Checked && rdnMinute2.Checked) {
                    lblResult.Text = cnv.dayToMinute(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Minutes";
                }
                else if (rdnDay.Checked && rdnHour2.Checked) {
                    lblResult.Text = cnv.dayToHour(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Hours";
                }
                else if (rdnDay.Checked && rdnWeek2.Checked) {
                    lblResult.Text = cnv.dayToWeek(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Weeks";
                }
                else if (rdnDay.Checked && rdnMonth2.Checked) {
                    lblResult.Text = cnv.dayToMonth(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Months";
                }
                else if (rdnDay.Checked && rdnYear2.Checked) {
                    lblResult.Text = cnv.dayToYear(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Years";
                }

                else if (rdnWeek.Checked && rdnSecond2.Checked) {
                    lblResult.Text = cnv.weekToSecond(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Seconds";
                }
                else if (rdnWeek.Checked && rdnMinute2.Checked) {
                    lblResult.Text = cnv.weekToMinute(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Minutes";
                }
                else if (rdnWeek.Checked && rdnHour2.Checked) {
                    lblResult.Text = cnv.weekToHour(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Hours";
                }
                else if (rdnWeek.Checked && rdnDay2.Checked) {
                    lblResult.Text = cnv.weekToDay(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Days";
                }
                else if (rdnWeek.Checked && rdnMonth2.Checked) {
                    lblResult.Text = cnv.weekToMonth(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Months";
                }
                else if (rdnWeek.Checked && rdnYear2.Checked) {
                    lblResult.Text = cnv.weekToYear(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Years";
                }

                else if (rdnMonth.Checked && rdnSecond2.Checked) {
                    lblResult.Text = cnv.monthToSecond(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Seconds";
                }
                else if (rdnMonth.Checked && rdnMinute2.Checked) {
                    lblResult.Text = cnv.monthToMinute(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Minutes";
                }
                else if (rdnMonth.Checked && rdnHour2.Checked) {
                    lblResult.Text = cnv.monthToHour(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Hours";
                }
                else if (rdnMonth.Checked && rdnDay2.Checked) {
                    lblResult.Text = cnv.monthToDay(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Days";
                }
                else if (rdnMonth.Checked && rdnWeek2.Checked) {
                    lblResult.Text = cnv.monthToWeek(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Weeks";
                }
                else if (rdnMonth.Checked && rdnYear2.Checked) {
                    lblResult.Text = cnv.monthToYear(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Years";
                }

                else if (rdnYear.Checked && rdnSecond2.Checked) {
                    lblResult.Text = cnv.yearToSecond(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Seconds";
                }
                else if (rdnYear.Checked && rdnMinute2.Checked) {
                    lblResult.Text = cnv.yearToMinute(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Minutes";
                }
                else if (rdnYear.Checked && rdnHour2.Checked) {
                    lblResult.Text = cnv.yearToHour(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Hours";
                }
                else if (rdnYear.Checked && rdnDay2.Checked) {
                    lblResult.Text = cnv.yearToDay(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Days";
                }
                else if (rdnYear.Checked && rdnWeek2.Checked) {
                    lblResult.Text = cnv.yearToWeek(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Weeks";
                }
                else if (rdnYear.Checked && rdnMonth2.Checked) {
                    lblResult.Text = cnv.yearToMonth(Convert.ToDouble(txtValue.Text)).ToString("0.##") + " Months";
                }
            }
            /// <summary>
            /// If Enter Null Value.
            /// </summary>
            catch (InvalidCastException) {
                lblResult.Text = "Null Value";
                lblResult.ForeColor = Color.Red;
            }
            /// <summary>
            /// If Enter Wrong Type Value
            /// </summary>
            catch (FormatException) {
                lblResult.Text = "Null Or Wrong Value";
                lblResult.ForeColor = Color.Red;
            }
            /// <summary>
            /// If Enter Too Large Value.
            /// </summary>
            catch (OverflowException) {
                lblResult.Text = "Too Large Integer";
                lblResult.ForeColor = Color.Red;
            }
            groupBox4.Enabled = true;
        }

        /// <summary>
        /// To Other Options Coordinating. 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnSecond_Click(object sender, EventArgs e) {
            groupbox3Checked();
            rdnEnabled();
            rdnChecked();
            rdnSecond2.Enabled = false;
        }

        /// <summary>
        /// To Other Options Coordinating. 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnMinute_Click(object sender, EventArgs e) {
            groupbox3Checked();
            rdnEnabled();
            rdnChecked();
            rdnMinute2.Enabled = false;
        }

        /// <summary>
        /// To Other Options Coordinating. 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnHour_Click(object sender, EventArgs e) {
            groupbox3Checked();
            rdnEnabled();
            rdnChecked();
            rdnHour2.Enabled = false;
        }
        /// <summary>
        /// To Other Options Coordinating. 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnDay_Click(object sender, EventArgs e) {
            groupbox3Checked();
            rdnEnabled();
            rdnChecked();
            rdnDay2.Enabled = false;
        }

        /// <summary>
        /// To Other Options Coordinating. 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnWeek_Click(object sender, EventArgs e) {
            groupbox3Checked();
            rdnEnabled();
            rdnChecked();
            rdnWeek2.Enabled = false;
        }

        /// <summary>
        /// To Other Options Coordinating. 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnMonth_Click(object sender, EventArgs e) {
            groupbox3Checked();
            rdnEnabled();
            rdnChecked();
            rdnMonth2.Enabled = false;
        }

        /// <summary>
        /// To Other Options Coordinating. 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnYear_Click(object sender, EventArgs e) {
            groupbox3Checked();
            rdnEnabled();
            rdnChecked();
            rdnYear2.Enabled = false;
        }
        /// <summary>
        /// To Other Options Coordinating. 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtValue_TextChanged(object sender, EventArgs e) {
            groupbox2Checked();
        }

        /// <summary>
        /// To Other Options Coordinating. 
        /// </summary>
        private void groupbox3Checked() {
            if (rdnDay.Checked || rdnHour.Checked || rdnMinute.Checked || rdnMonth.Checked || rdnSecond.Checked || rdnWeek.Checked || rdnYear.Checked) {
                groupBox3.Enabled = true;
            }
        }
        /// <summary>
        /// To Other Options Coordinating. 
        /// </summary>
        private void groupbox2Checked() {
            if (rdnDay.Checked || rdnHour.Checked || rdnMinute.Checked || rdnMonth.Checked || rdnSecond.Checked || rdnWeek.Checked || rdnYear.Checked) {
                groupBox2.Enabled = true;
            }
        }

        /// <summary>
        /// To Forbid Enter Values Without Numbers.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// To Other Options Coordinating.
        /// </summary>
        private void rdnEnabled() {
            rdnDay2.Enabled = true;
            rdnHour2.Enabled = true;
            rdnMinute2.Enabled = true;
            rdnMonth2.Enabled = true;
            rdnSecond2.Enabled = true;
            rdnWeek2.Enabled = true;
            rdnYear2.Enabled = true;
        }

        /// <summary>
        /// To Other Options Coordinating.
        /// </summary>
        private void rdnChecked() {
            rdnDay2.Checked = false;
            rdnHour2.Checked = false;
            rdnMinute2.Checked = false;
            rdnMonth2.Checked = false;
            rdnSecond2.Checked = false;
            rdnWeek2.Checked = false;
            rdnYear2.Checked = false;
            btnConvert.Enabled = false;
        }

        /// <summary>
        /// To Other Options Coordinating.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnSecond2_Click(object sender, EventArgs e) {
            btnConvert.Enabled = true;
        }

        /// <summary>
        /// To Other Options Coordinating.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnMinute2_Click(object sender, EventArgs e) {
            btnConvert.Enabled = true;
        }

        /// <summary>
        /// To Other Options Coordinating.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnHour2_Click(object sender, EventArgs e) {
            btnConvert.Enabled = true;
        }

        /// <summary>
        /// To Other Options Coordinating.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnDay2_Click(object sender, EventArgs e) {
            btnConvert.Enabled = true;
        }

        /// <summary>
        /// To Other Options Coordinating.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnWeek2_Click(object sender, EventArgs e) {
            btnConvert.Enabled = true;
        }

        /// <summary>
        /// To Other Options Coordinating.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnMonth2_Click(object sender, EventArgs e) {
            btnConvert.Enabled = true;
        }

        /// <summary>
        /// To Other Options Coordinating.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rdnYear2_Click(object sender, EventArgs e) {
            btnConvert.Enabled = true;
        }
    }
}
