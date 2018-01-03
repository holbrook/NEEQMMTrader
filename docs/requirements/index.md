{% uml %}
@startuml

actor :交易员: as Trader
actor :风控员: as RiskMngr
actor :总控人员: as Monitor
actor :运维人员: as Operator


usecase mgntStgy as "管理策略\n包括配置、启动、停止策略"

Trader -- mgntStgy
Trader -- (手工报价)
Trader -- (开盘报价)
Trader -- (风险监视)
Trader -- (报价状态)

Monitor -- (手工报价)
Monitor -- (报价状态)

RiskMngr -- (风险监视)
RiskMngr -- (设置指标)

Operator -- (监控集群状态)

(手工报价) ..> (风险控制)
(开盘报价) ..> (风险控制)

@enduml
{% enduml %}
