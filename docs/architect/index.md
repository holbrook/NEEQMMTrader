# 考虑的问题

- 是否需要分布式？

  Yes!

  要同时支持单机版和服务器版。

- 是否需要 Cluster ?

  Yes!

  可以实现去中心化，基于P2P的服务，没有单点故障（SPOF）问题

  节点越多，速度越快！

# 集群概念

{% uml %}
@startuml

Class Node {
    ActorSystem system
}

Class Cluster {
    int min-nr-of-members
}

Class Role {
    int min-nr-of-members
}

Class Topic {
    string topicName
}

Class Channel {
    Type channel
}

Cluster "1" o-down- "*" Node : membership
Cluster "1" -down- "1" Node : leader
Cluster "1" -down- "*" Node : seed-nodes


Cluster "1" -right- "*" Role
Role "*" -right- "*" Node

Node *-down- "*" Actor

Role -down- "*" Topic : publish
Role -down- "*" Topic : subscribe

Actor -right- Channel : subscribe
Actor -right- Channel : publish to

@enduml
{% enduml %}




# 角色划分

{% uml %}
@startuml

Class Role {
    int min-nr-of-members
}

Class Node {
    ActorSystem system
}


Role o-down- "*" Interface : need
Interface -down- "*" Implement

Role "*" -right- "*" Node
Node *-down- "*" Actor
Implement "*" -right- Actor : wrapper

@enduml
{% enduml %}


逻辑上：

- 集群中有很多 `Role`
- 每个 `Node` 可以扮演多个 `Role`
- 一个 `Role` 需要 很多 `Interface` 实现其功能

物理上：
-  一个 `Interface` 可以有很多个 `Implement`
- 选择某个 `Implement` 包装为 `Actor`
- 一个 `Actor` 可以包装多个 `Implement`
- `Actor` 部署到 `Node` 的  `ActorSystem` 中


Actor 之间只传递消息。 Context 自己保持。

比如，用户界面如果需要 Model，这个 Model 属于 UI。其他部分不共用。
