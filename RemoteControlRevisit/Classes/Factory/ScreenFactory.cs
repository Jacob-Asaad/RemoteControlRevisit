public abstract class ScreenFactory
{

    public CreateScreen(string modelName)
    {
        return modelName switch
        {
            "UN43TU7000" => new Un43Model();
            "UN50TU7000" => new Un50Model();
             "UN55TU7000" => new Un55Model();
              "UN58TU7000" => new Un58Model();
               "UN65TU7000" => new Un65Model();
                "UN70TU7000" => new Un70Model();
                "UN75TU7000" => new Un75Model();
        }
    }
}