import React from "react"
import * as PropTypes from "prop-types";
import './ImportanceDisplay.css';
import Bolt from "./Bolt";




class ImportanceDisplay extends React.Component {
    render() {
        let {importance} = this.props;

        let bolts = Array.apply(null, { length: importance }).map((e, i) => ( <Bolt /> ));

        return (

            <div className="ImportanceDisplay">
                {bolts}
            </div>
        )

    }
}

ImportanceDisplay.propTypes = {notes: PropTypes.any}

export default ImportanceDisplay