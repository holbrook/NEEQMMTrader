application --> actorsystem
perspective --> 透视图，每个用户角色
product --> deamon or GUI

# eclipse

MEF!

Eclipse平台的运行时就是一个纯粹的容器。所有的业务功能，都是封装在Eclipse的插件中的，尽管现在Eclipse RCP的开发炙手可热，但也不能脱离插件而单独存在。Eclipse中的Workspace，Team，JDT（Java开发工具包）和PDE（插件开发环境）本身就是用插件来实现的。


Eclipse平台本身的实现定义了很多的扩展点供你扩展，你可以从多个角度进行扩展，常见的扩展点有：
动作集（actionSet）；
编辑器（editor）；
弹出式菜单（popUpMenu）；
视图（views）；
透视图（perspectives）；
属性页(propertyPages)等。


界面：
Window, Parts, Perspective


your plugin--> {Workbench, Workspace}

其中：
Workbench 组件包含了一些扩展点，例如，允许您的插件扩展 Eclipse 用户界面，使这些用户界面带有菜单选择和工具栏按钮；请求不同类型事件的通知；以及创建新视图。

Workspace 组件包含了可以让您与资源（包括项目和文件）交互的扩展点。

插件也可以接入其他 extension points.


<plugin
id="com.example.hello"
name="Hello Plug-in"
version="1.0.0"
provider-name="EXAMPLE"
class="com.example.hello.HelloPlugin">

<runtime>
<library name="hello.jar"/>
</runtime>



<extension
point="org.eclipse.ui.actionSets">
<actionSet
label="Sample Action Set"
visible="true"
id="com.example.hello.actionSet">
<menu
label="Sample &Menu"
id="sampleMenu">
<separator
name="sampleGroup">
</separator>
</menu>
<action
label="&Sample Action"
icon="icons/sample.gif"
class="com.example.hello.actions.SampleAction"
tooltip="Hello, Eclipse world"
menubarPath="sampleMenu/sampleGroup"
toolbarPath="sampleGroup"
id="com.example.hello.actions.SampleAction">
</action>
</actionSet>
</extension>



sub project types:

plugin,
fragment,
feature,
product,
---
workspace???
    -- NormalWorkspace
    -- MMWorkspace
    -- 套利？
    --
