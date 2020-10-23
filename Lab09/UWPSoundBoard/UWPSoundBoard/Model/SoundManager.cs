using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<sound> sounds)
        {
            var allSounds = GetSounds();
            sounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));
        }
        private static List<sound> GetSounds()
        {
            var sounds = new List<sound>();

            sounds.Add(new sound("Cow", SoundCategory.Animals));
            sounds.Add(new sound("Cat", SoundCategory.Animals));
            return sounds;
        }
    }
}
