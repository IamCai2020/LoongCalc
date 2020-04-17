# LoongCalc

## 21-��Ŀ�ṹ
![File](Figures/file.png)
- ```LoongEgg.LoongCalc```��һ������̨������������������Ŀ
- ```LoongEgg.ViewModels```��һ����⣬������ViewModel
- ```LoongEgg.ViewModels.Test```��ViewModel�ĵ�Ԫ������Ŀ
- ```LoongEgg.Views```������View��Ҳ���Ǹ��ִ���Ϳؼ�
## 22-�����VS������MarkDown�ļ�
- ```MarkdownEditor Editor```��Ҫ��װ������
- ����ͼƬʱ�����пո���������ַ����ܳ���

## 23-Բ���ޱ߿����ƶ����ڿ���̨����WPF������ʾ����̨����
1. �����ޱ߿�����
```xml
    Width="360"
    Height="500"
    AllowsTransparency="True" ����͸���󳹵��ޱ߿�
    Background="#FFB4D2EC"
    WindowStartupLocation="CenterScreen" �������������Ļ�м�
    WindowStyle="None" �ޱ߿�
    MouseLeftButtonDown="Window_MouseLeftButtonDown" ��������ѹʱ�Ĵ����¼��������ƶ�����
```

2. Բ���и�
```xml
<Window.Clip>
        <RectangleGeometry
            RadiusX="30"
            RadiusY="30"
            Rect="0,0, 360, 500" />
</Window.Clip>
```

3. �����ƶ��ĺ�̨����
```c#
private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            DragMove();
        }
```

4. ���ӳ������� 
-   PresentationCore
-   PresentationFramework
-   System.Window
-   System.Window.Presentation
-   WindowsBase

5. ����Using
```c#
using LoongEgg.Views;
using System.Windows;
```

6. �ڿ���̨������WPF����
```c#
namespace LoongEgg.LoongCalc
{
    class Program
    {
        // TODO: 23-6 �ڿ���̨������WPF����
        [STAThread] // ��Ҫ���������ע
        static void Main(string[] args) {
            CalculatorView view = new CalculatorView();

            Application app = new Application();

            app.Run(view);

        }
    }
}

```

7. ����ʾ����̨����ķ���
�����������Ϊ```WindowsӦ�ó���```   
![23.Console Set](Figures/23.ConsoleSet.png)