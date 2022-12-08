using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruefungAfA
{
    internal class TimerAll
    {

        /// <summary>
        /// Singleton
        /// </summary>
        public static TimerAll Instance = new TimerAll();
        /// <summary>
        /// Zeit bis Ende (min, sek)
        /// </summary>
        public float ElapsedTime = 45 * 60;//45 min
        /// <summary>
        /// Geschwindigkeit der Zeit
        /// </summary>
        public float TimeSpeed = 0f;

        private DateTime lastUpdate;

        public TimerAll()
        {
            lastUpdate = DateTime.Now;
           
        }

        /// <summary>
        /// Modellaktualisierung
        /// </summary>
        public void Update()
        {
            //Abrufen aus dem letzten Aufruf von Update  Zeitintervalls
            var now = DateTime.Now;
            //Holen das Spielzeitintervall
            var dt = (float)(now - lastUpdate).TotalSeconds * TimeSpeed;
            lastUpdate = now;
            //aktualisieren Modell
            Update(dt);
            
            
        }
        /// <summary>
        /// Update Timer
        /// </summary>
        private void Update(float dt)
        {
            //verbleibende Zeit ändern 
            ElapsedTime -= dt;

            if (ElapsedTime < 0)
                ElapsedTime = 0;
        }

        /// <summary>
        /// Stopt Zeit Timer
        /// </summary>
        public void StopTime()
        {
            TimeSpeed = 0;
        }

        /// <summary>
        /// Start Timer
        /// </summary>
        public void StartTime()
        {
            TimeSpeed = 1;
        }
        


    }   
}
