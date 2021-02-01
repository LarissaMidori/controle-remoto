using System;

namespace controle_remoto
{
    public class ControleRemoto : IControlador
    {
        //Atributos
        private int volume;
        private bool ligado;
        private bool tocando;

        //Método Construtor 
        public ControleRemoto() 
        {
            this.volume = 50;
            this.ligado = true;
            this.tocando = false;
        }

        //Getters e Setters
        public int Volume
        {
            get { return this.volume; }
            set { this.volume = value; }
        }

        public bool Ligado
        {
            get { return this.ligado; }
            set { this.ligado = value; }
        }

        public bool Tocando
        {
            get { return this.tocando; }
            set { this.tocando = value; }
        }

        //Métodos Abstratos
         public void ligar()
         {
             this.Ligado = true;
             
         }
         public void desligar()
         {
             this.Ligado = false;
              this.Volume = this.Volume = 0;
         }
         public void abrirMenu()
         {
             Console.WriteLine("----MENU----");
             Console.WriteLine("Está ligado? " + Ligado);
             Console.WriteLine("Está tocando? " + Tocando);
             Console.Write("Volume: " + Volume + " ");
             for(int i = 1; i <= this.Volume; i+=10) 
             {
                 Console.Write("|");
             }
             Console.WriteLine("");
         }
         public void fecharMenu()
         {
             Console.WriteLine("Fechando o menu...");
         }
         public void maisVolume()
         {
             if(this.Ligado == true)
             {
                 this.Volume = this.Volume + 5;
             } 
         }
         public void menosVolume()
         {
             if(this.Ligado == true)
             {
                 this.Volume = this.Volume - 5;
             } 
         }
         public void ligarMudo()
         {
             if((this.Ligado == true) && (this.Volume > 0 ))
             {
                 this.Volume = 0;
             }
         }
         public void desligarMudo()
         {
             if((this.Ligado == true) && (this.Volume == 0))
             {
                 this.Volume = 50;
             }
         }
         public void play()
         {
             if((this.Ligado == true) && !(this.Tocando))
             {
                 this.Tocando = true;
             }
         }
         public void pause()
         {
             if((this.Ligado == true) && (this.Tocando))
             {
                 this.Tocando = false;
             }
         }
    }
}