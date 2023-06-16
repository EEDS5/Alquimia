class ProductCard extends HTMLElement{
    constructor(){
      super();
  
      //Creamos el shadwDomn en modo open para permitir el acceso del exterior
      const shadow = this.attachShadow({mode: 'open'});

      //Definir los atributos personalizados
      const title = this.getAttribute('title');
      const description = this.getAttribute('description');
      const price = this.getAttribute('price');
      const image = this.getAttribute('image');

      /*
      * Creación de elementos HTML para representar la tarjeta de producto.
      */

      const cardContainer = document.createElement('div');
      cardContainer.classList.add('product-card');

      const imageElement = document.createElement('img');
      imageElement.src = image;
      imageElement.alt = 'Producto';
      cardContainer.appendChild(imageElement);

      const titleElement = document.createElement('h2');
      titleElement.classList.add('product-title');
      titleElement.textContent = title;
      cardContainer.appendChild(titleElement);

      const descriptionElement = document.createElement('p');
      descriptionElement.classList.add('product-description');
      descriptionElement.textContent = description;
      cardContainer.appendChild(descriptionElement);

      const priceElement = document.createElement('p');
      priceElement.classList.add('product-price');
      priceElement.textContent = price;
      cardContainer.appendChild(priceElement);

      const addToCartButton = document.createElement('button');
      addToCartButton.classList.add('add-to-cart-btn');
      addToCartButton.textContent = 'Añadir al carrito';
      cardContainer.appendChild(addToCartButton);

      /**
       * Logica del contador
       */

      const counterElement = document.createElement('p');
      let count = 0;
      counterElement.textContent = `Cantidad: ${count}`;
      cardContainer.appendChild(counterElement);

      addToCartButton.addEventListener('click', () =>
      {
        count++;
        counterElement.textContent = `Cantidad: ${count}`;

      });

      /*
      * Carga de estilos externos
      */ 

      shadow.appendChild(cardContainer);

      const link = document.createElement('link');
      link.setAttribute('rel', 'stylesheet');
      link.setAttribute('href', 'estilos.css');
      shadow.appendChild(link);
    }
  
  }
  customElements.define('product-card',ProductCard);
  