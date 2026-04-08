import { Tabs } from "expo-router"

export default function LayoutRoot(){
    return(
        <Tabs>
            <Tabs.Screen name="index" options={{title: "Home"}}/>
            <Tabs.Screen name="contatos" options={{title: "Contatos"}}/>
            <Tabs.Screen name="tela1" options={{title: "Tela 1"}}/>
            <Tabs.Screen name="tela2" options={{title: "Tela 2"}}/>
        </Tabs>
    )
}