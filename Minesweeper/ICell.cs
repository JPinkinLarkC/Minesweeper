namespace Minesweeper //Cambiar el nombre del namespace
{
    interface ICell 
    {
        int GetValue();
        bool IsHidden();

        void LeftClick();
        void RightClick();
    }
}
