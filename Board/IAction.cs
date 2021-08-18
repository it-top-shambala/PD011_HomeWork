namespace Board
{
    public interface IAction
    {
        public void Write(string content, int x, int y);  // Вывести сонтент по координатам
        public void Erase();  //  Очистить всё поле
        public void Clean(int x1, int y1, int x2, int y2);  //  Очистить поле ограниченное координатами
    }
}
