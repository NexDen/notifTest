import { Text, View } from "react-native";
import { LogLevel, OneSignal } from "react-native-onesignal";


export default function Index() {

	OneSignal.Debug.setLogLevel(LogLevel.Verbose);
	OneSignal.initialize("c1c8e717-5215-46fd-9b08-cef91f55751e");

	OneSignal.Notifications.requestPermission(true);

	OneSignal.Notifications.addEventListener("click", (event) => {
		console.log("OneSignal: notification clicked:", event);
	});

	return (
		<View
		style={{
			flex: 1,
			justifyContent: "center",
			alignItems: "center",
		}}
		>
		<Text>Edit app/index.tsx to edit this screen.</Text>
		</View>
	);
}
