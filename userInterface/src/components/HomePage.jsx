import { useState } from "react";
import SectionWrapper from "../hoc/SectionWrapper";
import "./Introduction.css"
import SideMenu from "./SideMenu";

const Introduction = () => {
    return (
        <div className="introduction">
            <div className="project-name-background">
                <h1 className="introduction-appName">
                    Newtonian Apples
                </h1>
            </div>
            <div className="introduction-content">
                <h2>
                    About this project
                </h2>

                <p>
                    Explanation
                </p>
            </div>
        </div>
    )
}

const SearchBar = () => {
    return (
        <></>
    )
}

const HomePage = () => {
    return (
        <>
            <Introduction />
            <SearchBar />
            <SideMenu />
        </>
    )
}

export default SectionWrapper(HomePage, "home");