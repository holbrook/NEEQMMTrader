# 委托

## 委托方式

MarketOrder
LimitOrder
StopOrder

## 报单状态

{% uml %}
@startuml

[*] -> 待报 : 【客户端】下单
待报 -> 正报 : 【服务器】收到委托
正报 -> 废单 :【交易所】委托无效
废单 -> [*]
正报 --> 已报 : 【交易所】确认委托
已报 --> 已成 : 【交易所】成交确认
已报 --> 部成 : 【交易所】成交确认

@enduml
{% enduml %}

## 撤单状态

{% uml %}
@startuml

[*] -> 待撤 : 【客户端】撤单
待撤 -> 正撤 : 【服务器】收到撤单指令
正撤 --> 已撤 :【交易所】之前未成交(已报)
正撤 --> 部撤 :【交易所】之前部分成交(部成)
正撤 --> 撤废 :【交易所】之前已成交(已成)或者订单不存在

@enduml
{% enduml %}

## 金证股转做市系统状态对应

<table>
    <tr><th>金证状态码</th><th>金证状态</th><th>通用状态映射</th><th>金证说明</th></tr>
    <tr><td>0</td><td>未报   </td><td>待报</td><td>写入委托的最初阶段，该笔业务还没有到申报时间</td></tr>
    <tr><td>1</td><td>正报   </td><td>正报</td><td>该标志是漏单扫描的中间状态，表示正在判断中</td></tr>
    <tr><td>2</td><td>已报   </td><td>已报</td><td>已经成功写入接口库</td></tr>
    <tr><td>3</td><td>已报待撤</td><td>待撤</td><td>    该笔业务被撤单，但撤单未成交</td></tr>
    <tr><td>4</td><td>部成待撤</td><td>待撤</td><td>    该笔业务部分成交，剩余部分等待撤单</td></tr>
    <tr><td>5</td><td>部撤   </td><td>部撤</td><td>部分撤单</td></tr>
    <tr><td>6</td><td>已撤   </td><td>已撤</td><td>撤单已经成交</td></tr>
    <tr><td>7</td><td>部成已撤</td><td>部撤</td><td>    部分成交</td></tr>
    <tr><td>8</td><td>已成   </td><td>已成</td><td>已经成交</td></tr>
    <tr><td>9</td><td>废单   </td><td>废单</td><td>被交易所自动撤单</td></tr>
    <tr><td>A</td><td>待报   </td><td>待报</td><td>写入报盘队列未成功</td></tr>
</table>
