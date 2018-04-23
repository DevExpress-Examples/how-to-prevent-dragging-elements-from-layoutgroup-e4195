' Developer Express Code Central Example:
' How to prevent dragging elements from LayoutGroup
' 
' This example demonstrates how to allow customizing items only inside
' LayoutGroup. All custom logic is implemented in the
' LayoutItemDragAndDropController and LayoutControlController descendants. To
' allow adding new "isolated groups" to LayoutControl, a
' LayoutControlCustomizationController descendant was created.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4195


Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows

' Управление общими сведениями о сборке осуществляется с помощью 
' набора атрибутов. Измените значения этих атрибутов, чтобы изменить сведения,
' связанные со сборкой.
<Assembly: AssemblyTitle("LayoutCntMoveInGroup")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("Microsoft")>
<Assembly: AssemblyProduct("LayoutCntMoveInGroup")>
<Assembly: AssemblyCopyright("Copyright © Microsoft 2012")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Параметр ComVisible со значением FALSE делает типы в сборке невидимыми 
' для COM-компонентов.  Если требуется обратиться к типу в этой сборке через 
' COM, задайте атрибуту ComVisible значение TRUE для этого типа.
<Assembly: ComVisible(False)>

'Чтобы начать построение локализованных приложений, задайте 
'<UICulture>CultureYouAreCodingWith</UICulture> в файле .csproj
'внутри <PropertyGroup>.  Например, если используется английский США
'в своих исходных файлах установите <UICulture> в en-US.  Затем отмените преобразование в комментарий
'атрибута NeutralResourceLanguage ниже.  Обновите "en-US" в
'строка внизу для обеспечения соответствия настройки UICulture в файле проекта.

'[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


	'(используется, если ресурс не найден на странице 
	' или в словарях ресурсов приложения)
	'(используется, если ресурс не найден на странице, 
	' в приложении или в каких-либо словарях ресурсов для конкретной темы)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>


' Сведения о версии сборки состоят из следующих четырех значений:
'
'      Основной номер версии
'      Дополнительный номер версии 
'      Номер построения
'      Редакция
'
' Можно задать все значения или принять номер построения и номер редакции по умолчанию, 
' используя "*", как показано ниже:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
