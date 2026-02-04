namespace Course
{
    internal class Product
    {
        private string _name = ""; // convenção de nomenclatura para campos privados em C#
        private double _price;
        private int _quantity;

        public double Price2 { get; private set; }  // Propriedade automática para o preço do produto
        // private set; torna a propriedade somente leitura fora da classe Product
        public string Name2 { get; set; }  // Propriedade automática para o nome do produto
        // propriedade automática não permite adicionar lógica personalizada nos métodos Get e Set
        // para isso, precisamos usar a sintaxe completa de propriedades
        // Exemplo:
        // public string Name
        // {
        //     get { return _name; }
        //     set
        //     {
        //         if (value != null && value.Length > 1)  //usa o value para referenciar o valor que está sendo atribuído à propriedade 
        //         {                                       // nesse caso, o value é o valor que está sendo passado para a propriedade Name
        //             _name = value;
        //         }
        //     }
        // }

        public Product(string name, double price, int quantity)  // Construtor da classe Product
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public Product(string name, double price)  // Sobrecarga do construtor da classe Product
        {
            _name = name;
            _price = price;
            _quantity = 0; 
        }

        // Encapsulamento: controlando o acesso aos atributos da classe através de métodos Get e Set
        // Metodo manual de encapsulamento para o atributo nome
        // Get e Set são métodos públicos que permitem acessar e modificar o valor do atributo privado _name
        public string GetName()  // Método Get para acessar o nome do produto
        {
            return _name;
        }

        public void SetName(string name)   // Método Set para modificar o nome do produto
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
        }

        // usando propriedades (properties):

        public string Name  // Propriedade para acessar e modificar o nome do produto
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }


        public double GetPrice()  // Método Get para acessar o preço do produto, não fornecemos um Set para o preço, tornando-o somente leitura evitando modificações diretas
        {
            return _price;
        }

        public int GetQuantity()  // Método Get para acessar a quantidade do produto
        {
            return _quantity;
        }

        public double GetTotalValueInStock()
        {
            return _price * _quantity;
        }

        public void AddProducts(int quantity)
        {
            _quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            _quantity -= quantity;
        }

        // Sobreposição de método (override) é um polimorfismo de substituição 
        // Permite que uma subclasse forneça uma implementação específica de um método que já é definido em sua superclasse
        // Neste caso, estamos sobrescrevendo o método ToString() da classe base Object
        // para fornecer uma representação personalizada do objeto Product
        override public string ToString()
        {
            return _name
                + ", $ "
                + _price.ToString("F2")
                + ", "
                + _quantity
                + " units, Total: $ "
                + GetTotalValueInStock().ToString("F2");
        }
    }
}

// Propertys:
// As propriedades (properties) em C# são uma forma mais concisa e elegante de implementar o encapsulamento
// Elas permitem definir métodos Get e Set de forma automática, sem a necessidade de escrever código adicional
// Exemplo de propriedade automática para o atributo nome
// public string Name { get; set; }
// Neste exemplo, a propriedade Name permite acessar e modificar o valor do atributo nome de forma direta
// Product product = new Product("TV", 900.00, 10);
// string name = product.Name; // Acessando o nome do produto
// product.Name = "Computer"; // Modificando o nome do produto
// Podemos também definir propriedades somente leitura ou somente escrita
// public string Name { get; } // Somente leitura
// public string Name { set; } // Somente escrita
