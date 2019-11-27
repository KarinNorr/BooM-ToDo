using System.Collections.Generic;
namespace BoomLibrary
{

    //Enum styr vilken view som ska visas av metod för att visa Note
    public enum NoteView { Basic = 1, Light, Expanded }

    public class NoteManager
    {
        //variabel som håller håller koll på när senaste review gjordes
        public int ReviewTime = 0;

        //metod som tar bort en note
        public string DeleteNote(Note note, List<Note> listofnotes)
        {
            try
            {
                int noteIndex = listofnotes.FindIndex(note);
            }
            catch
            {
                return "Det fanns ingen sån här note";

            }
            listofnotes.RemoveAt(noteIndex);
            return "Nu är din note borta!";
        }

        //metod som visar en note 
        //kallar på andra metoder beroende på inparametrar
        //En enum styr vilken vy som kommer att visas 

        public string ShowNote(NoteView view)
        {
            switch (view)
            {
                case 1:
                    GetBasicView();
                    return;

                case 2:
                    GetLightView();
                    return;

                case 3:
                    GetExpandedView();
                    return;

                default:
            }
        }

        //Visar endast titel på en Note 
        private string GetBasicView(Note note)
        {
            string title = note.Title;
            return "Denna Note heter: " + title;

        }

        //Light view, titel plus status
        private string GetLightView(Note note)
        {
            string title = note.Title;
            Status status = note.Status;
            return "Denna Note har titel: " + titel + " med status: " + status;
        }

        //Expanded view tom 50 tecken i beskrivningen

        private string GetExpandedView(Note note)
        {
            note.ToString();
        }

        //Metod som ändrar status på en note
        public void ChangeStatus(Note note, GTD_Status status)
        {
            note.SetStatus(status);
        }

        //Metod som flyttar Note framåt i flödet
        public int MoveNoteForward(Note note)
        {
            currentStatus = note.GetStatus;
            if(currentStatus = note.GetStatus.
            note.SetStatus(currentStatus++);



            //note.SetStatus(note.GetStatus++);
        }

        //Metod som returnerar Booms

        public string RewardWithBooms(int boomcounter)
        {
            string str = "";
        }
    }
}


