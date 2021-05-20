
<table style="width: 100%;">
  <tr>
    <td style="text-align: center; border: none;">
    Министерство образования и науки РФ<br>
Государственное бюджетное профессиональное образовательное учреждение Республики Марий Эл<br>
Йошкар-Олинский технологический колледж
</td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 15em;">
    <h2 style="font-size:3em;">Отчет</h2>
      <h3>по лабораторной работе<br><br> по дисциплине "Основы алгоритмизации и программирования"<br><br> Тема:<b>"Каркас приложения. Модель данных. Привязка данных. Табличный вывод."<b> </h3></td>
  </tr>
  <tr>
    <br><br><td style="text-align: right; border: none; height: 20em;">
      Разработал:<br/>
      Малинин Никита<br>
      Группа: И-21<br>
      Преподаватель:<br>
      Колесников Евгений Иванович
    </td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 5em;">
    г.Йошкар-Ола, 2021</td>
  </tr>
</table>

<div style="page-break-after: always;"></div>

# Цели и задачи:
 1. Создать Модель данных
 2. Создать Каркас приложения.
 3. Привязка данных. Табличный вывод


# Краткий материал.


Сначала создадим класс для элемента справочника

```
public class CatBreed { 
    public string Title { get; set; }
}
```

Пока в этом особого смысла нет, но при работе с БД у нас будут таки классы, поэтому сразу привыкаем к правильному коду.

Создаем в классе главного окна свойство для хранения справочника

```
public List<CatBreed> CatBreedList { get; set; }
```

Здесь мы выбрали тип List, т.к. нам нужен изменяемый список, в который мы добавим элемент "Все породы"

В интерфейс поставщика данных (IDataProvider) добавляем метод для получения списка категорий

```
IEnumerable<CatBreed> GetCatBreeds();
```

2. Чтобы задать позицию элемента управления с привязкой к определенной ячейке Grid-а, в разметке элемента нужно прописать значения свойств Grid.Column и Grid.Row, тем самым указывая, в каком столбце и строке будет находиться элемент. Кроме того, если мы хотим растянуть элемент управления на несколько строк или столбцов, то можно указать свойства Grid.ColumnSpan и Grid.RowSpan, как в следующем примере:

    ```
![Лабораторная](.\screen\worker.png)
```xml
 <Window x:Class="WpfApp40.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp40"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid >
        <Grid.RowDefinitions>
            <RowDefinition Height="auto"/>
            <RowDefinition/>
            <RowDefinition Height="50"/>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="200"/>
            <ColumnDefinition/>
        </Grid.ColumnDefinitions>
```


```xml
        <!--Приложение-->
        <Image
                Source="C:\Users\User\Downloads\1.png"
                Grid.RowSpan="2"/>
        <StackPanel
                Orientation="Vertical"
                Grid.RowSpan="3"
                VerticalAlignment="Bottom">
            <Button
                    x:Name="ExitButton"
                    Content="Выход"
                    Click="ExitButton_Click"
                    Height="50"/>
        </StackPanel>
        <WrapPanel
                Orientation="Horizontal"
                Grid.Column="1"
                MinHeight="50">
        </WrapPanel>
        <DataGrid
                Grid.Row="1"
                CanUserAddRows="True"
                AutoGenerateColumns="False"
                ItemsSource="{Binding WorkerList}" Margin="198,1,2,49" Grid.RowSpan="2" Grid.ColumnSpan="2">
            <DataGrid.Columns>
                <DataGridTextColumn
                        Header="ФИО"
                        Binding="{Binding Surname}"/>
                <DataGridTextColumn
                        Header="Должность"
                        Binding="{Binding Role}"/>
                <DataGridTextColumn
                        Header="год начала работы"
                        Binding="{Binding Year}"/>
                <DataGridTextColumn
                        Header="Зарплата"
                        Binding="{Binding Salary}"/>
            </DataGrid.Columns>
        </DataGrid>
    </Grid>
</Window>

```

# Вывод

Мы научились работать и создавать WPF-приложения и компоновкой, создавать приложение WPF .NET Framework, исследовали контейнеры
А так же Grid, StackPanel, WrapPanel"# wpfKolesnikov" 
