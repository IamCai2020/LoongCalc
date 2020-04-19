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

## 25-Blend������а�ť��̬��WPF��ʽ���
![25.Button](Figures/25.Button.png)
- ����е�ʵ����������������һ���ͼ�Σ�һ��ʹ����ɫ��Ӱһ����ɫ��ӰӪ���
- ���Խ��Զ���ͼ������Buttonʱ�����һ��ViewBoxʵ�ֳߴ������Ӧ
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

            <!--  �ػ���  -->
            <Style x:Key="ButtonStyles.PowerOff" TargetType="{x:Type Button}">
                <Setter Property="Template">
                    <Setter.Value>
                        <ControlTemplate TargetType="{x:Type Button}">
                            <!--  �������һ��ViewBoxʵ�ֿؼ�������Ӧ����  -->
                            <Viewbox>
                                <Grid>
                                    <Grid>
                                        <Ellipse
                                            Width="80"
                                            Height="80"
                                            Margin="5"
                                            HorizontalAlignment="Center"
                                            Fill="#FFB4D2EC">
                                            <Ellipse.Effect>
                                                <DropShadowEffect />
                                            </Ellipse.Effect>
                                        </Ellipse>
                                        <Ellipse
                                            Width="80"
                                            Height="80"
                                            Margin="5"
                                            HorizontalAlignment="Center"
                                            Fill="#FFB4D2EC">
                                            <Ellipse.Effect>
                                                <DropShadowEffect Direction="135" Color="#FFF4FAFF" />
                                            </Ellipse.Effect>
                                        </Ellipse>
                                    </Grid>
                                    <ContentPresenter
                                        HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
                                        VerticalAlignment="{TemplateBinding VerticalContentAlignment}"
                                        RecognizesAccessKey="True"
                                        SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}" />
                                </Grid>
                            </Viewbox>
                            <ControlTemplate.Triggers>
                                <Trigger Property="IsFocused" Value="True" />
                                <Trigger Property="IsDefaulted" Value="True" />
                                <Trigger Property="IsMouseOver" Value="True" />
                                <Trigger Property="IsPressed" Value="True" />
                                <Trigger Property="IsEnabled" Value="False" />
                            </ControlTemplate.Triggers>
                        </ControlTemplate>
                    </Setter.Value>
                </Setter>
            </Style>
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
        <StackPanel VerticalAlignment="Center">
            <!--  ����͡��֡��������嵽�˾�̬��Դ������ʹ��  -->
            <!--  �ػ���  -->
            <Button
                x:Name="button"
                Width="130"
                Height="130"
                Content="{StaticResource Icons.PowerOff}"
                FontFamily="{StaticResource Fonts.Icon}"
                FontSize="50"
                Foreground="Chocolate"
                Style="{DynamicResource ButtonStyles.PowerOff}" />

        </StackPanel>
    </Grid>
</Window>

```
## 26-WPF�ؼ���Һ������̬��άЧ��
```xml
<!--  ���������Һ����  -->
            <Grid Height="120" Margin="20,0,20,0">
                <Grid.Clip>
                    <RectangleGeometry
                        RadiusX="12"
                        RadiusY="12"
                        Rect="0,0, 320, 120" />
                </Grid.Clip>
                <Rectangle Fill="White" Opacity="0.5" />
                <Canvas x:Name="canvas">
                    <Path
                        Width="{Binding ElementName=canvas, Path=ActualWidth}"
                        Height="{Binding ElementName=canvas, Path=ActualHeight}"
                        Fill="Black"
                        Opacity="0.5">
                        <Path.Data>M0,0 L320,0  L300,20 L20,100  L0,120</Path.Data>
                    </Path>
                </Canvas>
                <Rectangle
                    Margin="10"
                    Fill="#FF343434"
                    RadiusX="9"
                    RadiusY="9" />
            </Grid>
```
## 27-ToggleButton��Button�Ķ�����ʽ
- ��Blend�п���ͼ�λ���ƺ�Ԥ��
- 
## 28-��UniformGrid������ɲ���
- ��Grid�������ڲ��ö���Grid.Row��Grid.Column,���ηŽ�ȥ����
- ���Ҫ�յ�ĳ��λ�ã���һ���ؼ���ȥ��Ȼ��Visibility=Hidden��

# C#��̸߼����ţ���ѧ���ʽ���������
## 29-�沨�����ʽ��TokenType, �½����
- �沨�����ʽ
```c#
    /// ��׺���ʽ   2 + 3 * (4 -5)
    /// �沨�����ʽ [2][3][4][5][-][*][+]
```
- TokenType.cs
```c#
    /// <summary>
    /// Token������ö��
    /// </summary>
    public enum TokenType
    {
        /// <summary>
        /// �������+ - * / ^
        /// </summary>
        Operator,

        /// <summary>
        /// ��  ����cos sin etc..
        /// </summary>
        Function,

        /// <summary>
        /// ��������.0123456789
        /// </summary>
        Operand,
         
        /// <summary>
        /// �����ţ�(
        /// </summary>
        LeftBracket,

        /// <summary>
        ///  �����ţ�)
        /// </summary>
        RightBracket,
    }
```
