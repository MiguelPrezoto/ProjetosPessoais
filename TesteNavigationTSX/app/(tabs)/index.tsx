import { View, Text , StyleSheet} from "react-native"

export default function Index(){
    return(
        <View style={styles.container}>
            <Text style={styles.h1}> Index </Text>
        </View>
    )
}

const styles = StyleSheet.create({
    container: {
        padding: 24,
    },
    h1: {
        fontSize: 32,
        fontWeight: '700',
        color: '#111827',
        marginBottom: 12,
    },
})