# Unity_Design_Patterns

## To use : 

1.Creational Patterns : Singleton, ObjectPool, Prototype(?)
1.Structural Patterns : Decorator, Facade, Bridge(?)
1.Behavioral Patterns : ???

### Wzorzec most, przykładowa implementacja : 
```c#
 class Program
    {
        static void Main(string[] args)
        {
            Switch tvButton = new ClickSwitch(new TV());
 
            tvButton.On();
            tvButton.Off();
            
            Console.ReadKey();
        }
    }
 
    abstract class Switch
    {
        protected IDevice device;
 
        public Switch(IDevice device)
        {
            this.device = device;
        }
 
        public abstract void On();
 
        public abstract void Off();
    }
 
    class ClickSwitch : Switch
    {
        public ClickSwitch(IDevice device):base(device)
        { }
 
        public override void On()
        {
            device.On();
        }
 
        public override void Off()
        {
            device.Off();
        }
    }
 
    interface IDevice
    {
        void On();
        void Off();
    }
 
    class TV : IDevice
    {
        public void Off()
        {
            Console.WriteLine("the TV was turned off");
        }
 
        public void On()
        {
            Console.WriteLine("the TV was turned on");
        }
    }
    ```
