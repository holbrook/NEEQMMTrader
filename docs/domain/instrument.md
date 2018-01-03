# 金融工具

Instrument

股票、债券、基金、指数、权证、商品期货、外汇等多项品种

股票： Stock
债券： Bond


衍生品derivative instrument：


期权（Option）是在期货的基础上产生的一种金融工具。从其本质上讲，期权实质上是在金融领域中将权利和义务分开进行定价，使得权利的受让人在规定时间内对于是否进行交易，行使其权利，而义务方必须履行。
期货(Futures)与现货完全不同，现货是实实在在可以交易的货(商品)，期货主要不是货，而是以某种大宗产品如棉花、大豆、石油等及金融资产如股票、债券等为标的标准化可交易合约。
股票是股份公司发行的所有权凭证，是股份公司为筹集资金而发行给各个股东作为持股凭证并借以取得股息和红利的一种有价证券。


{% uml %}
@startuml

Class Instrument {
    string Code
    string Name
    string MarketCode
}

Class Stock {

}

Class NEEQMMStock {

}

Instrument <|-- Stock
Stock <|-- NEEQMMStock

Class Index {

}

Instrument <|-- Index

Class Bond {

}

Instrument <|-- Bond

Class Future {

}

Instrument <|-- Future

Class Option {

}

Instrument <|-- Option


@enduml
{% enduml %}
