using HomeWork4.Interfaces;


namespace HomeWork4.Abstract
{
    internal abstract class SettingItem:ISetting
    {
        public int Value { get; set; }

        public abstract int SetValue();
    }
}
