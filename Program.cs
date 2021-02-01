using System;

namespace controle_remoto
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleRemoto controle1 = new ControleRemoto();
            controle1.ligar();
            controle1.play();
            controle1.menosVolume();
            controle1.pause();
            controle1.abrirMenu();

            ControleRemoto controle2 = new ControleRemoto();
            controle2.ligar();
            controle2.maisVolume();
            controle2.play();
            controle2.abrirMenu();
            controle2.fecharMenu();

            ControleRemoto controle3 = new ControleRemoto();
            controle3.desligar();
            controle3.maisVolume();
            controle3.abrirMenu();




        }
    }
}
