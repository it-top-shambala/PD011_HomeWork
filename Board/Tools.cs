namespace Board
{
    public enum Writer
    {
        Chalk, Marker, Pointer
    }

    public enum Cleaner
    {
        Sponge, Napkin, Pointer
    }

    public class Tools
    {
        public Writer Writer { get; set; }  //  Инструмент для написания
        public Cleaner Cleaner { get; set; }  //  Инструмент для стирания

        public Tools() { }
        public Tools(Writer writer, Cleaner cleaner)
        {
            Writer = writer;
            Cleaner = cleaner;
        }

        public Tools ToolChalk()
        {
            //  Создать инструменты для меловой доски
            return new Tools(Writer.Chalk, Cleaner.Sponge);
        }
        public Tools ToolMarker()
        {
            //  Создать инструменты для маркерной доски
            return new Tools(Writer.Marker, Cleaner.Napkin);
        }
        public Tools ToolInteractive()
        {
            //  Создать инструменты для интерактивной доски
            return new Tools(Writer.Pointer, Cleaner.Pointer);
        }
    }


}
