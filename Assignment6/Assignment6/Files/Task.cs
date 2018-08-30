using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Files
{
    /// <summary>
    /// This class represents a task and contains date, decription and priority information of the task.
    /// </summary>
    public class Task
    {
        private DateTime date;
        private string description;
        private PriorityType priority;


        /// <summary>
        /// Constructor with three parameters
        /// </summary>
        /// <param name="date">date of the task </param>
        /// <param name="priority">priority of the task</param>
        /// <param name="description">description of the task</param>
        public Task(DateTime date, PriorityType priority, string description)
        {
            this.date = date;
            this.description = description;
            this.priority = priority;

        }

        /// <summary>
        /// Property related to the field date
        /// Both read and write access
        /// </summary>
        public DateTime Date
        {

            get
            {
                return date;
            }
            set
            {
                date = value;
            }

        }

        /// <summary>
        /// Property related to the field description
        /// Both read and write access
        /// </summary>
        public string Discription
        {

            get
            {
                return description;
            }
            set
            {
                description = value;
            }

        }

        /// <summary>
        /// Property related to the field priority
        /// Both read and write access
        /// </summary>
        public PriorityType Priority
        {

            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }

        }

        /// <summary>
        /// This method converts the priority to string and
        /// replace all "_" with " " in the priority
        /// </summary>
        /// <returns></returns>
        public string GetPriorityString()
        {
            return priority.ToString().Replace("_", " ");
        }

        /// <summary>
        /// This method returns the time as string
        /// </summary>
        /// <returns></returns>
        public string GetTimeString()
        {
            return date.ToShortTimeString();
        }

        /// <summary>
        /// This method returns a string which contains all information about the task.
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {

            return $"{date.ToShortDateString(),-12}                         " +
                   $"{GetTimeString(),-7}              " +
                   $"{GetPriorityString(),-16}                 " +
                   $"{description}";
        }

    }
}
