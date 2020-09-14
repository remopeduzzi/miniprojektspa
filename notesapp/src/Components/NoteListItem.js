import React from "react";

const NoteListItem = ({note}) => {
return(
    <div>
        <div>{note.title}</div>
        <div>{note.description}</div>
        <div>{note.importance}</div>
    </div>
)
}

export default NoteListItem