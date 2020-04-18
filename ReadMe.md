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

![Dinosaur](Figures/Dinosaur.png)

## 24-�ڳ�����ȷ������Դ
**�����þ���·��**
1. ���½���``Themes\Fonts.xaml``��Դ�ֵ������ⲿ�Զ�������  
``LoongEgg.Views``Ϊ���򼯵�����  
``application``��``component``Ϊ��׼�÷�����Ҫȥ��    
``/Assets/``Ϊ����Դ���ļ���·��
```xml
<!--  ʹ���Զ������� #�������������������Դ����������������ļ��ҵ��������ȥ  -->
    <FontFamily x:Key="Fonts.Icon">pack://application:,,,/LoongEgg.Views;component/Assets/#Font Awesome 5 Free Solid</FontFamily>
```
2. ���ض���ͼ�ꡰ�֡�����Ϊ��̬��Դ 
``system:String``��Դ�����õ����ƿռ�``xmlns:system="clr-namespace:System;assembly=mscorlib"``
```xml
<!--  ����һ��ͼ�ꡰ�֡��ľ�̬��Դ  -->
    <system:String x:Key="Icons.PowerOff">&#xf011;</system:String>
```
3. Ϊ�˷���ʹ�ã�Ӧ�ð�������Դ���ϵ��Զ���ؼ����``Themes\Generic.xaml``
```xml
<ResourceDictionary
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="clr-namespace:LoongEgg.Views">

    <ResourceDictionary.MergedDictionaries>

        <!--  ��������װ������Դ  -->
        <ResourceDictionary Source="/LoongEgg.Views;component/Themes/Fonts.xaml" />
    </ResourceDictionary.MergedDictionaries>

</ResourceDictionary>

```
4. �ڴ���������Դ
```xml
<Window
    x:Class="LoongEgg.Views.CalculatorView"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:local="clr-namespace:LoongEgg.Views"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    Title="CalculatorView"
    Width="360"
    Height="500"
    AllowsTransparency="True"
    Background="#FFB4D2EC"
    MouseLeftButtonDown="Window_MouseLeftButtonDown"
    WindowStartupLocation="CenterScreen"
    WindowStyle="None"
    mc:Ignorable="d">

    <Window.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <!--  ��Ϊ������Դ�������ϵ�Generic.xaml������ֻ��Ҫ������  -->
                <ResourceDictionary Source="/LoongEgg.Views;component/Themes/Generic.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Window.Resources>

    <!--  �и�Բ��  -->
    <Window.Clip>
        <RectangleGeometry
            RadiusX="30"
            RadiusY="30"
            Rect="0,0, 360, 500" />
    </Window.Clip>

    <Grid>
        <!--  ����͡��֡��������嵽�˾�̬��Դ������ʹ��  -->
        <Button
            Content="{StaticResource Icons.PowerOff}"
            FontFamily="{StaticResource Fonts.Icon}"
            FontSize="56" />
    </Grid>
</Window>

```
