namespace Board
{
    class Interactiv:Board,IAction
    {
        //  Интерактивная доска.
        public string Content { get; set; }  // Содержание доски

        //  Сообщание для вывода.
        public Message Info;  //  Делегат для сообщений

        public Interactiv(string name, int height, int length)
        {
            Name = name;
            HeightInMM = height;
            LengthInMM = LengthInMM;
            Tool = new Tools().ToolInteractive();
        }

        public void Write(string content, int x, int y)
        {
            Content += content;
            Info.Invoke($"На интерактивную доску добавлен контент по ({x},{y}).");
        }

        public void Erase()
        {
            Content = "";
            Info.Invoke($"Интерактивная доска чистая.");
        }

        public void Clean(int x1, int y1, int x2, int y2)
        {
            string ContentXXYY = "";
            Content += ContentXXYY;
            Info.Invoke($"Интерактивная доска очищена по ({x1},{y1}:{x2},{y2}).");
        }

    }
}
