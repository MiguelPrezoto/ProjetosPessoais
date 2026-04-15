import { Pressable, StyleSheet, Text } from 'react-native'

type Propriedades = {
    name: string
}

export function ButtonComponent(props: Propriedades){
    return(
        <Pressable>
            <Text style={styles.container}> {props.name}</Text>
        </Pressable>
    )
}

const styles = StyleSheet.create({
    container:{
        backgroundColor: 'green'
    }
})