using System;
using System.Collections.Generic;


namespace C3_Practice
{
    class Configuration {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value) {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item) {
            foreach (ItemValue iv in listConfig) {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }

            return "";
        }

        private class ItemValue { // Configuration 클래스 안에서 선언된 중첩 클래스. private이기 때문에 Configuration 클래스 밖에서는 보이지 않음
            private string item;
            private string value;

            public void SetValue(Configuration config, string item, string value) {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++) {
                    if (config.listConfig[i].item == item) {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }

                if (found == false)
                    config.listConfig.Add(this);
            }

            public string GetItem() {
                return item;
            }

            public string GetValue() {
                return value;
            }
        }
    }

    class NestedClass {
        static void Main(string[] args) {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655,324 KB");

            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.0.1");
            Console.WriteLine(config.GetConfig("Version"));
        }
    }
}
