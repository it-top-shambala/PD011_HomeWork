namespace Board
{
    public class Marker : Board, IAction
    {
        //  Маркерная доска.
        public string Content { get; set; }  // Содержание маркерной доски

        //  Сообщание для вывода.
        public Message Info;  //  Делегат для сообщений

        public Marker(string name, int height, int length)
        {
            Name = name;
            HeightInMM = height;
            LengthInMM = LengthInMM;
            Tool = new Tools().ToolMarker();
        }

        public void Clean(int x1, int y1, int x2, int y2)
        {
            string ContentXXYY = "";
            Content += ContentXXYY;
            Info.Invoke($"Маркерная доска очищена по ({x1},{y1}:{x2},{y2}).");
        }

        public void Erase()
        {
            Content = "";
            Info.Invoke($"Маркерная доска чистая.");
        }

        public void Write(string content, int x, int y)
        {
            Content += content;
            Info.Invoke($"На маркерную доску добавлен контент по ({x},{y}).");
        }
    }
}
