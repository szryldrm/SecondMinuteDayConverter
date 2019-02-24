// ***********************************************************************
// Assembly         : CoverterTest
// Author           : SezerYildirim
// Created          : 03-07-2017
//
// Last Modified By : SezerYildirim
// Last Modified On : 03-07-2017
// ***********************************************************************
// <copyright file="UnitTest1.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace CoverterTest {
    /// <summary>
    /// Class UnitTest1.
    /// </summary>
    [TestClass]
    public class UnitTest1 {
        /// <summary>
        /// Create A Class For Methods.
        /// </summary>
        SecondMinuteDayConverter.converters cnv = new SecondMinuteDayConverter.converters();

        /// <summary>
        /// Seconds to minute.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(60, 1)]
        public void secondToMinute(Double income, Double expected) {
            Double actual = cnv.secondToMinute(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Seconds to hour.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(3600, 1)]
        public void secondToHour(Double income, Double expected) {
            Double actual = cnv.secondToHour(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Seconds to day.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(86400, 1)]
        public void secondToDay(Double income, Double expected) {
            Double actual = cnv.secondToDay(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Seconds to week.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(604800, 1)]
        public void secondToWeek(Double income, Double expected) {
            Double actual = cnv.secondToWeek(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Minutes to second.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 60)]
        public void MinuteToSecond(Double income, Double expected) {
            Double actual = cnv.minuteToSecond(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Minutes to hour.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(60, 1)]
        public void MinuteToHour(Double income, Double expected) {
            Double actual = cnv.minuteToHour(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Minutes to day.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1440, 1)]
        public void MinuteToDay(Double income, Double expected) {
            Double actual = cnv.minuteToDay(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Minutes to week.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(10080, 1)]
        public void MinuteToWeek(Double income, Double expected) {
            Double actual = cnv.minuteToWeek(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Hours to second.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 3600)]
        public void HourToSecond(Double income, Double expected) {
            Double actual = cnv.hourToSecond(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Hours to minute.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 60)]
        public void HourToMinute(Double income, Double expected) {
            Double actual = cnv.hourToMinute(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Days to second.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 86400)]
        public void DayToSecond(Double income, Double expected) {
            Double actual = cnv.dayToSecond(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Days to minute.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 1440)]
        public void DayToMinute(Double income, Double expected) {
            Double actual = cnv.dayToMinute(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Days to hour.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 24)]
        public void DayToHour(Double income, Double expected) {
            Double actual = cnv.dayToHour(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Weeks to second.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 604800)]
        public void WeekToSecond(Double income, Double expected) {
            Double actual = cnv.weekToSecond(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Weeks to minute.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 10080)]
        public void WeekToMinute(Double income, Double expected) {
            Double actual = cnv.weekToMinute(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Weeks to hour.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 168)]
        public void WeekToHour(Double income, Double expected) {
            Double actual = cnv.weekToHour(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Weeks to day.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 7)]
        public void WeekToDay(Double income, Double expected) {
            Double actual = cnv.weekToDay(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Monthes to minute.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 43829.0639)]
        public void MonthToMinute(Double income, Double expected) {
            Double actual = cnv.monthToMinute(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Years to second.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 31556926)]
        public void YearToSecond(Double income, Double expected) {
            Double actual = cnv.yearToSecond(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Years to month.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="expected">The expected.</param>
        [TestCase(1, 12)]
        public void YearToMonth(Double income, Double expected) {
            Double actual = cnv.yearToMonth(income);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
