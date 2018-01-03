{% uml %}
@startuml

Class Portofolio {

}

Portofolio o-- Asset
Asset -left- Instrument
Asset -right- "1..*" Position
Position -down- Account
Account "*" -- "*" Broker

@enduml
{% enduml %}
