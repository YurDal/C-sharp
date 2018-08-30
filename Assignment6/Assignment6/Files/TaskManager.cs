using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Files
{
    /// <summary>
    ///  This class use a List object for storing objects of type Task.
    /// </summary>
    public class TaskManager
    {

        private List<Task> taskList;

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaskManager()
        {

            taskList = new List<Task>();
        }

        /// <summary>
        /// This method retruns the numbers of total elements in the taskList;
        /// </summary>
        public int Count
        {
            get
            {
                return taskList.Count;
            }

        }

        /// <summary>
        /// This method adds the given Customer object in the end of the List.
        /// </summary>
        /// <param name="task"></param>
        public void Add(Task task)
        {
            taskList.Add(task);
            taskList.Sort((x, y) => x.Date.CompareTo(y.Date));
        }

        /// <summary>
        /// This method returns an array of strings where each string is a formatted text line containing data for each task.
        /// </summary>
        /// <returns></returns>
        public string[] ListToStringArray()
        {
            string[] taskArray = new string[Count];
            for (int i = 0; i < Count; i++) taskArray[i] = taskList[i].ToString();
            return taskArray;
        }

    }
}
