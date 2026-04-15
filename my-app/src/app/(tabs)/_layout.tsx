import { Tabs } from "expo-router"

export default function LayoutRoot(){
    return(
        <Tabs>
            <Tabs.Screen name="status" options={{title: "Status"}}/>
            <Tabs.Screen name="chamadas" options={{title: "Chamadas"}}/>
            <Tabs.Screen name="comunidades" options={{title: "Comunidades"}}/>
            <Tabs.Screen name="index" options={{title: "Conversas"}}/>
            <Tabs.Screen name="voce" options={{title: "Você"}}/>
        </Tabs>
    )
}