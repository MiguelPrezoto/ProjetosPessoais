import { Tabs } from "expo-router";
import { Ionicons } from "@expo/vector-icons";

export default function LayoutRoot() {
  return (
    <Tabs
      screenOptions={{
        tabBarActiveTintColor: "#128c7e",
        tabBarInactiveTintColor: "#6B7280",
        tabBarLabelStyle: {
          fontSize: 12,
          fontWeight: "600",
          textTransform: "none"
        },
        tabBarStyle: {
            backgroundColor: "#ece5dd"
        },
        sceneStyle: {
            backgroundColor: '#ece5dd'
        }
      }}
    >
      <Tabs.Screen
        name="status"
        options={{
          tabBarLabel: "Status",
          tabBarIcon: ({ color, size, focused }) => (
            <Ionicons
              name={focused ? "ellipse" : "ellipse-outline"}
              color={color}
              size={size}
            />
          ),
        }}
      />
      <Tabs.Screen
        name="chamadas"
        options={{
          tabBarLabel: "Chamadas",
          tabBarIcon: ({ color, size, focused }) => (
            <Ionicons
              name={focused ? "call" : "call-outline"}
              color={color}
              size={size}
            />
          ),
        }}
      />
      <Tabs.Screen
        name="comunidades"
        options={{
          tabBarLabel: "Comunidades",
          tabBarIcon: ({ color, size, focused }) => (
            <Ionicons
              name={focused ? "people" : "people-outline"}
              color={color}
              size={size}
            />
          ),
        }}
      />
      <Tabs.Screen
        name="index"
        options={{
          tabBarLabel: "Conversas",
          tabBarIcon: ({ color, size, focused }) => (
            <Ionicons
              name={focused ? "chatbubbles" : "chatbubbles-outline"}
              color={color}
              size={size}
            />
          ),
        }}
      />
      <Tabs.Screen
        name="voce"
        options={{
          tabBarLabel: "Você",
          tabBarIcon: ({ color, size, focused }) => (
            <Ionicons
              name={focused ? "person" : "person-outline"}
              color={color}
              size={size}
            />
          ),
        }}
      />
    </Tabs>
  );
}
