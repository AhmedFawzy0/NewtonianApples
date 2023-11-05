import { Unity, useUnityContext } from "react-unity-webgl";
import "./Introduction.css"

const Kinematics = () => {

    const { unityProvider } = useUnityContext({
        loaderUrl: "cannonBall/cannon-prototype-game.loader.js",
        dataUrl: "cannonBall//cannon-prototype-game.data.unityweb",
        frameworkUrl: "cannonBall/cannon-prototype-game.framework.js.unityweb",
        codeUrl: "cannonBall//cannon-prototype-game.wasm.unityweb",
    });

    return (
        <div className="kinematics-demo">
            <Unity unityProvider={unityProvider}/>
        </div>
    )
}

export default Kinematics