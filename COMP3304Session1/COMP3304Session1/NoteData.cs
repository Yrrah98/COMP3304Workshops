using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    class NoteData : INoteData, ITextData
    {

        private IDictionary<int, String> _noteText;

        

        private IList<String> _images;

        private IDictionary<int, Image> _imgDictionary;

        private Random rndImg;

        public NoteData()
        {

            rndImg = new Random();

            _noteText = new Dictionary<int, String>();

            _images = new List<String>();

            ((List<String>)_images).AddRange((Directory.GetFiles((Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Images")))));
            
            

            _imgDictionary = new Dictionary<int, Image>();
        }

        public void AddNote(int key, String txt)
        {
            _noteText[key] = txt;

            int rnd = rndImg.Next(0, _images.Count());

            Image nImg = Image.FromFile(_images[rnd]);

            _imgDictionary[key] = nImg;

        }

        public void RemoveNote(int key)
        {
            _noteText.Remove(key);
        }

        public String Retrieve(int key)
        {

            // IF the dictionary contains the key passed in
            if (_noteText.ContainsKey(key))
                // THEN return the value found at the specified element 
                return _noteText[key];
            else
                // THEN return a message stating the lack of existing element
                return null;

        }

        public void Replace(int key, String replacementTxt)
        {
            _noteText[key] = replacementTxt;
        }

        public Image ReturnImage(int key)
        {

            Image rtrnImg = _imgDictionary[key];

            return rtrnImg;
        }
    }
}
