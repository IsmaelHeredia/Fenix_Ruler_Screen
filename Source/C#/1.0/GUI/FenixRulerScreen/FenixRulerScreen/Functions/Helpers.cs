using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace FenixRulerScreen
{
    class Helpers
    {
        public void play_sound(string option)
        {
            SoundPlayer sound = new SoundPlayer();

            if (option == "click")
            {
                sound = new SoundPlayer(FenixRulerScreen.Properties.Resources.click);
            }
            else if (option == "loaded")
            {
                sound = new SoundPlayer(FenixRulerScreen.Properties.Resources.formcreate);
            }
            else if (option == "done")
            {
                sound = new SoundPlayer(FenixRulerScreen.Properties.Resources.done);
            }
            else
            {
                sound = new SoundPlayer(FenixRulerScreen.Properties.Resources.click);
            }

            sound.Play();
        }
    }
}
