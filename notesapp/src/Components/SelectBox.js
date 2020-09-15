import React from "react"
import * as PropTypes from "prop-types";
import NoteListItem from "./NoteListItem";




class NoteList extends React.Component {
    render() {
        let {notes} = this.props;


        return (

            <div className="NoteList">


                {notes.map((note) => <NoteListItem note={note} /> )}
            </div>
        )

    }
}

NoteList.propTypes = {notes: PropTypes.any}

export default NoteList