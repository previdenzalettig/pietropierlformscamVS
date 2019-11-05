using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiFormsCamuso
{
  public partial class Form1 : Form//partial significa che vediamo solo ciò che scriviamo noi, non il resto che è contenuto nella classe Form di System.Windows.Forms.
  {
    public Form1()
    {
      InitializeComponent();//Metodo=comando invocato su un oggetto->costruttore del form->inizializzatore del form->//Inizializza una nuova istanza della classe System.Object.  Membro di System.Object-
      risultatoTxt.Text = "RISULTATO";//ereditarietà->cambia il valore della variabile->espressione(...)del tipo corrispondente alla variabile->compatibile con il destinatario


    }

    private void button1_Click(object sender, EventArgs e)//Metodo=comando invocato su un oggetto->costruttore del form->inizializzatore del form
    {
      /*string cognome = "   CAMUSO  ";
      cognome.Trim();
      MessageBox.Show("Ciao pierino");
      */

      int num1, num2 = 0;//Inizializza una nuova istanza della classe System.Object.  Membro di System.Object->Oggetto=Esemplare(istanza di una classe->La classe rappresenta il tipo dell'oggetto.

      /*
                   //ALTERNATIVA1/METODO1->

                   num1 = Convert.ToInt32(num1Txt.Text);
                           if (num1 < 0)
                   {
                     MessageBox.Show("ERRORE! solo numeri>=0");
                     ......
                    }
                    else
                    {
                    int num2=0;
                    .....}//Convert->funzione/metodo
      */

      /*             
      //ALTERNATIVA/METODO2->
      
      bool conversioneValida = int.TryParse(num1Txt.Text, out num1);
      if (!conversioneValida)//==false
      MessageBox.Show("ERRORE!Non è un numero");
       .....}
      else
              if (num1 < 0)
      {
        MessageBox.Show("ERRORE! solo numeri>=0");
        num1Txt.Clear();//num1Text="";->metodo può essere con o senza parametri.
        num1Txt.Focus();
      }
      else
      {

        int num2 = 0
        ......}//TryParse ->METODO con parametri>Parametro num1Txt.Text->passaggio per VALORE o per COPIA(true/false).Opera SOLO sul VALORE assunto in questo istante dalla  variabile num1Txt.Text, non sulla varibile stessa.
      Parametro out->Cambia il passaggio da VALORE a per INDIRIZZO/RIFERIMENTO->parametro di USCITA(non solo copia)ed opera SOLO su num1.
      */

      //*ALTERNATIVA/METODO3->

      if (!int.TryParse(num1Txt.Text, out num1))
      {
        if (num1Txt.Text == "")
          MessageBox.Show("ERRORE!La prima casella è vuota");
        else
          MessageBox.Show("ERRORE!Non è un numero");
        num1Txt.Clear();//num1Text="";->metodo può essere con o senza parametri.
        num1Txt.Focus();

      }

      else

           if (!int.TryParse(num2Txt.Text, out num2))
      {
        if (num2Txt.Text == "")
          MessageBox.Show("ERRORE!La seconda casella è vuota");
        else
          MessageBox.Show("ERRORE!Non è un numero");
        num2Txt.Clear();//num2Text="";->metodo può essere con o senza parametri.
        num2Txt.Focus();

      }
      else//attenzione!!

      if (num1 < 0)
      {
        MessageBox.Show("ERRORE! solo numeri>=0");
        num1Txt.Clear();//num1Text="";->metodo può essere con o senza parametri.
        num1Txt.Focus();
      }
      else
      {

        num2 = 0;//Inizializza una nuova istanza della classe System.Object.  Membro di System.Object->Oggetto=Esemplare(istanza di una classe->La classe rappresenta il tipo dell'oggetto.
        num2 = Convert.ToInt32(num2Txt.Text);//Convert->funzione/metodo

        if (num2 < 0)
        {
          MessageBox.Show("ERRORE! solo numeri>=0");
          num2Txt.Clear();//num1Text="";->metodo può essere con o senza parametri.
          num2Txt.Focus();
        }


        int num3 = num1 + num2;//espressione
        risultatoTxt.Text = num3.ToString();//Convert.ToString(num3)->Oggetto=Esemplare(istanza di una classe->La classe rappresenta il tipo dell'oggetto.

      }




    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
