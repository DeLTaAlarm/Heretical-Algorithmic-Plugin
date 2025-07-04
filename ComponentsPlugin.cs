using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using PluginBase;

namespace HereticalAlgorithmicPlugin;

[PluginData("Встроенный редактор компонентов", "Встроенный плагин для управления компонентами данных ECS архитектуры", "icons/.png", ".hcomp", "Компонент данных", "Компонент для хранения данных сущностей")]
public class ComponentsPlugin : PluginBaseClass, IPluginEditorUI
{
    public async Task ShowCreationDialogAsync(Window parentWindow, string path, Action<object> onCreated)
    {

    }

    public Control GetEditorUI(string path, Action<object> onSave)
    {
        throw new NotImplementedException();
    }

    public override void OnCompile(string path, object parameters)
    {
        throw new NotImplementedException();
    }

    public override void OnCreate(string path, object parameters)
    {

    }

    public override void OnDelete(string path, object parameters)
    {
        throw new NotImplementedException();
    }

    public override void OnMove(string oldPath, string newPath, object parameters)
    {
        throw new NotImplementedException();
    }

    public override void OnOpen(string path, object parameters)
    {
        throw new NotImplementedException();
    }

    public override void OnRename(string oldPath, string newPath, object parameters)
    {
        throw new NotImplementedException();
    }

    public override void OnSave(string path, object parameters)
    {
        throw new NotImplementedException();
    }
}
