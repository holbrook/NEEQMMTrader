# 用户
{% uml %}
@startuml

rectangle "用户" {
    actor 交易员
    actor 风控员
    actor 总控员
    actor 运维人员
}

rectangle "界面" {
    agent 手工报价
    agent 配置策略
    agent 启动停止策略
    agent 行情监控
    agent 系统监控
    agent 设置风控指标
    agent 风险监视
}

rectangle "服务" {
    component component
}

交易员 -- 手工报价
手工报价 -- component

@enduml
{% enduml %}





# 角色划分

客户端角色，都有界面

## 风控服务

接口：

- 风险监视
- 风险控制


## 手工报价客户端

接口：

- 行情监视
- 持仓监视
- 状态监视

## 风控员客户端

- 风险监视
- 风险指标设置

## 总控客户端

