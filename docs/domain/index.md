# 核心概念

## Order

{% uml %}
@startuml

Order "*" -right- "1" Instrument
Order <|-- LongOrder
Order <|-- ShortOrder

@enduml
{% enduml %}


# Quote

{% uml %}
@startuml

Class Quote {

}

Class MMQuote {
    double bid
    double offer
    double mid
    double spread
}
note right: constraint:\n spread=bid-offer \n mid = (bid + offer)/2


@enduml
{% enduml %}
