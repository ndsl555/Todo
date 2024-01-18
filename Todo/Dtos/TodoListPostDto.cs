using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Dtos
{
    public class TodoListPostDto
    {
        public string Name { get; set; }
        public bool Enable { get; set; }
        public int Orders { get; set; }

        public List<UploadFilePostDto> UploadFiles { get; set; }

    }
}
