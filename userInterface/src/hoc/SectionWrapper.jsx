import "./SectionWrapper.css"
import CopyRight from "./CopyRight"

const SectionWrapper = (OriginalComponent, id) => {
    return (
        function NewComponent() {
            return (
                <section className="newSection">
                    <OriginalComponent />
                    <CopyRight />
                </section>
            )
        }
    )
}

export default SectionWrapper;