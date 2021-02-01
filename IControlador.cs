namespace controle_remoto
{
    public interface IControlador
    {
          void ligar();
          void desligar();
          void abrirMenu();
          void fecharMenu();
          void maisVolume();
          void menosVolume();
          void ligarMudo();
          void desligarMudo();
          void play();
          void pause();
    }
}