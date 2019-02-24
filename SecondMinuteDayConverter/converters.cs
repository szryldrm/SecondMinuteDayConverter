// ***********************************************************************
// Assembly         : SecondMinuteDayConverter
// Author           : SezerYildirim
// Created          : 03-05-2017
//
// Last Modified By : SezerYildirim
// Last Modified On : 03-07-2017
// ***********************************************************************
// <copyright file="converters.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondMinuteDayConverter {
    /// <summary>
    /// Class converters.
    /// </summary>
    class converters {
        /* Second To Other Converter Start */
        /// <summary>
        /// Convert Seconds to minute.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Minutes</returns>
        public Double secondToMinute(Double value) {
            return value / 60;
        }
        /// <summary>
        /// Convert Seconds to Hour.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Hour</returns>
        public Double secondToHour(Double value) {
            return value / 3600;
        }
        /// <summary>
        /// Convert Seconds to Day.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Day</returns>
        public Double secondToDay(Double value) {
            return value / 86400;
        }
        /// <summary>
        /// Convert Seconds to Week.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Week</returns>
        public Double secondToWeek(Double value) {
            return value / 604800;
        }
        /// <summary>
        /// Convert Seconds to Month.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Month</returns>
        public Double secondToMonth(Double value) {
            return value / 2628002.88;
        }
        /// <summary>
        /// Convert Seconds to Year.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Year</returns>
        public Double secondToYear(Double value) {
            return secondToMonth(value) / 12;
        }

        /* Second To Other Converter Finish */

        /* Minute To Other Converter Start */

        /// <summary>
        /// Convert Minutes to Second.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Second</returns>
        public Double minuteToSecond(Double value) {
            return value * 60;
        }
        /// <summary>
        /// Convert Minutes to Hour.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Hour</returns>
        public Double minuteToHour(Double value) {
            return value / 60;
        }
        /// <summary>
        /// Convert Minutes to Day.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Day</returns>
        public Double minuteToDay(Double value) {
            return value / 1440;
        }
        /// <summary>
        /// Convert Minutes to Week.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Week</returns>
        public Double minuteToWeek(Double value) {
            return value / 10080;
        }
        /// <summary>
        /// Convert Minutes to Month.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Month</returns>
        public Double minuteToMonth(Double value) {
            return minuteToDay(value) / 30.4167;
        }
        /// <summary>
        /// Convert Minutes to Year.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Year</returns>
        public Double minuteToYear(Double value) {
            return value / 525600;
        }

        /* Minute To Other Converter Finish */

        /* Hours To Other Converter Start */

        /// <summary>
        /// Convert Hour to Second.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Second</returns>
        public Double hourToSecond(Double value) {
            return value * 3600;
        }
        /// <summary>
        /// Convert Hour to Minute.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Minute</returns>
        public Double hourToMinute(Double value) {
            return value * 60;
        }
        /// <summary>
        /// Convert Hour to Day.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Day</returns>
        public Double hourToDay(Double value) {
            return value / 24;
        }
        /// <summary>
        /// Convert Hour to Week.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Week</returns>
        public Double hourToWeek(Double value) {
            return value / 168;
        }
        /// <summary>
        /// Convert Hour to Month.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Month</returns>
        public Double hourToMonth(Double value) {
            return value / 730.0008;
        }
        /// <summary>
        /// Convert Hour to Year.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Year</returns>
        public Double hourToYear(Double value) {
            return value / 8760;
        }

        /* Hour To Other Converter Finish */

        /* Day To Other Converter Start */

        /// <summary>
        /// Convert Day to Second.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Second</returns>
        public Double dayToSecond(Double value) {
            return value * 86400;
        }
        /// <summary>
        /// Convert Day to Minute.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Minute</returns>
        public Double dayToMinute(Double value) {
            return value * 1440;
        }
        /// <summary>
        /// Convert Day to Hour.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Hour</returns>
        public Double dayToHour(Double value) {
            return value * 24;
        }
        /// <summary>
        /// Convert Day to Week.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Week</returns>
        public Double dayToWeek(Double value) {
            return value / 7;
        }
        /// <summary>
        /// Convert Day to Month.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Month</returns>
        public Double dayToMonth(Double value) {
            return value / 30.4167;
        }
        /// <summary>
        /// Convert Day to Year.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Year</returns>
        public Double dayToYear(Double value) {
            return value / 365;
        }

        /* Day To Other Converter Finish */

        /* Week To Other Converter Start */

        /// <summary>
        /// Convert Week to Second.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Second</returns>
        public Double weekToSecond(Double value) {
            return value * 604800;
        }
        /// <summary>
        /// Convert Week to Minute.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Minute</returns>
        public Double weekToMinute(Double value) {
            return value * 10080;
        }
        /// <summary>
        /// Convert Week to Hour.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Hour</returns>
        public Double weekToHour(Double value) {
            return value * 168;
        }
        /// <summary>
        /// Convert Week to Day.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Day</returns>
        public Double weekToDay(Double value) {
            return value * 7;
        }
        /// <summary>
        /// Convert Week to Month.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Month</returns>
        public Double weekToMonth(Double value) {
            return value / 4.34524;
        }
        /// <summary>
        /// Convert Week to Year.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Year</returns>
        public Double weekToYear(Double value) {
            return value / 52.14285714;
        }

        /* Week To Other Converter Finish */

        /* Month To Other Converter Start */

        /// <summary>
        /// Convert Month to Second.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Second</returns>
        public Double monthToSecond(Double value) {
            return value * 2628002.88;
        }
        /// <summary>
        /// Convert Month to Minute.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Minute</returns>
        public Double monthToMinute(Double value) {
            return value * 43829.0639;
        }
        /// <summary>
        /// Convert Month to Hour.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Hour</returns>
        public Double monthToHour(Double value) {
            return value * 730.0008;
        }
        /// <summary>
        /// Convert Month to Day.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Day</returns>
        public Double monthToDay(Double value) {
            return value * 30.4167;
        }
        /// <summary>
        /// Convert Month to Week.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Week</returns>
        public Double monthToWeek(Double value) {
            return value * 4.34524;
        }
        /// <summary>
        /// Convert Month to Year.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Year</returns>
        public Double monthToYear(Double value) {
            return value / 12;
        }

        /* Month To Other Converter Finish */

        /* Year To Other Converter Start */

        /// <summary>
        /// Convert Year to Second.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Second</returns>
        public Double yearToSecond(Double value) {
            return value * 31556926;
        }
        /// <summary>
        /// Convert Year to Minute.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Minute</returns>
        public Double yearToMinute(Double value) {
            return value * 525600;
        }
        /// <summary>
        /// Convert Year to Hour.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Hour</returns>
        public Double yearToHour(Double value) {
            return value * 8760;
        }
        /// <summary>
        /// Convert Year to Day.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Day</returns>
        public Double yearToDay(Double value) {
            return value * 365;
        }
        /// <summary>
        /// Convert Year to Week.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Week</returns>
        public Double yearToWeek(Double value) {
            return value * 52.14285714;
        }
        /// <summary>
        /// Convert Year to Month.
        /// </summary>
        /// <param name="value">Input</param>
        /// <returns>Double Month</returns>
        public Double yearToMonth(Double value) {
            return value * 12;
        }

        /* Year To Other Converter Finish */
    }
}
