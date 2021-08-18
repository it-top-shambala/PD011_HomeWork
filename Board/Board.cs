namespace Board
{
    public delegate void Message(string message);
    public abstract class Board
    {
        //  Характеристики доски
        public string Name { get; set; }  //  Имя или инвентарный номер
        public int HeightInMM { get; set; }  //  Высота в мм
        public int LengthInMM { get; set; }  //  Длина в мм

        public Tools Tool { get; set; }

        protected Board() { }
        protected Board(string name, int height, int length, Tools tool)
        {
            Name = name;
            HeightInMM = height;
            LengthInMM = length;
            Tool = tool;
        }
    }
}
