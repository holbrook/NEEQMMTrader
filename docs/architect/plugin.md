Workspace，能够完成特定的功能
由一组 Role 组成
这些 Role 可能分布在不同的节点；一个 Role 可以有多个实例。

在物理上，Workspace 对应到一个 Cluster
每个 Node 部署多个 Role (是 workspace 的一个子集)

在物理上，Unit对应到一个 Actor
一个 Unit 可以扮演一个或多个 Role

在物理上，Node 有一些邻居（Remote Node)，共同构成 Cluster


{% uml %}
@startuml

artifact MonoTrader.Deamon
artifact MonoTrader.WorkBench
artifact MonoTrader.Core
artifact Workspace

MonoTrader.Deamon -- MonoTrader.Core
MonoTrader.WorkBench -- MonoTrader.Core
MonoTrader.Core -- Workspace

@enduml
{% enduml %}

{% uml %}
@startuml

artifact GeneralWorkspace


@enduml
{% enduml %}


{% uml %}
@startuml

artifact NEEQMMWorkspace


@enduml
{% enduml %}



{% uml %}
@startuml

Class Workspace {

}

Class Role {

}

package "capablity" {
    Workspace -- "*" Role
}


package deploy {
    Cluster -- "*" Actor : "roles"
}

@enduml
{% enduml %}
