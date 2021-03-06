/*
 * Notes API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class NotesApiController : ControllerBase
    { 
        /// <summary>
        /// Add a new note
        /// </summary>
        
        /// <param name="body">Note object that needs to be added to the store</param>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/remopeduzzimas/notes/1.0.0/notes")]
        [ValidateModelState]
        [SwaggerOperation("AddNote")]
        public virtual IActionResult AddNote([FromBody]Note body)
        { 
            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a note
        /// </summary>
        
        /// <param name="noteId">Note id to delete</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Note not found</response>
        [HttpDelete]
        [Route("/remopeduzzimas/notes/1.0.0/notes/{noteId}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteNote")]
        public virtual IActionResult DeleteNote([FromRoute][Required]string noteId)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all notes
        /// </summary>
        /// <remarks>Gets all notes</remarks>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid tag value</response>
        [HttpGet]
        [Route("/api/notes/")]
        [ValidateModelState]
        [SwaggerOperation("GetAllNotes")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Note>), description: "successful operation")]
        public virtual IActionResult GetAllNotes()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Note>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

          
            //TODO: Change the data returned
            return new ObjectResult(Startup.notes);
        }

        /// <summary>
        /// Update an exiting note
        /// </summary>
        
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        /// <response code="405">Validation exception</response>
        [HttpPut]
        [Route("/remopeduzzimas/notes/1.0.0/notes")]
        [ValidateModelState]
        [SwaggerOperation("UpdateNote")]
        public virtual IActionResult UpdateNote([FromBody]Note body)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);


            throw new NotImplementedException();
        }
    }
}
