using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneStore_8_feb_2018 {
    class Track {

        /// <summary>
        /// Creates a new instance with the location
        /// </summary>
        /// <param name="Location">The location of the file</param>
        public Track(String Location) {
            if (!String.IsNullOrEmpty(Location)) {
                string[] split = Location.Split('\\');
                this.SafeFileName = split[split.Length - 1];
                this.FileName = Location;
            }
        }

        /// <summary>
        /// The location of the file
        /// </summary>
        public String FileName { get; set; }
        /// <summary>
        /// The filename without the location
        /// </summary>
        public String SafeFileName { get; set; }
        /// <summary>
        /// How the file shows up in the list
        /// </summary>
        public String DisplayName { get; set; }

    }
}
