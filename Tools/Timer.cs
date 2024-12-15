namespace AXNotification.Tools
{

    public class Timer
    {
        private bool running = false;
        private bool hasSent = false;
        private static Timer instance = new Timer();

        private List<int> NORMAL_DRINK_TIMES = new List<int>()
        {
            6,9,11,13,15,17,20,22
        };

        public static Timer Build()
        {
            return instance;
        }
        public void Start()
        {
            if (running) return;
            running = true;
            Task task = new Task(() =>
            {
                while(running)
                {
                    foreach (var time in NORMAL_DRINK_TIMES)
                    {
                        var currentTime = DateTime.Now;
                        if(currentTime.Hour == time && !hasSent)
                        {
                            WindowEvents.SendToast($"Current time: {currentTime:HH:mm:ss}", $"You Need Drink Water!");
                            this.hasSent = true;
                        }
                    }
                }
            });
            task.Start();
        }
       
    }
}
