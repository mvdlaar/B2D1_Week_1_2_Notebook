using System.Collections.Generic;

namespace B2D1_Week_1_2_Notebook
{
    class Notebook
    {
        /*
         * List<x> y = new List<x>();
         * 
         * ...
         * 
         * y.Add(item);
         * z = y[index]; // Haalt item op positie index op
         * y.Count;
         */
        

        //initialiseer notes in de constructor
        private List<string> notes;

        public void StoreNote(string note)
        {
            // Sla note op
        }

        public int NumberOfNotes()
        {
            return 0; // return in plaats van 0 het aantal items in note
        }

        public string ShowNote(int index)
        {
            return "No notes stored"; // return in plaats van de gegeven tekst de juiste inhoud van het item op de gegeven index
        }

}
}
