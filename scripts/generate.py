from datetime import datetime
from jinja2 import Template
import yaml
from pathlib import Path
import shutil
import os

SOURCE_PATH = Path("./src")
GENERATED_PATH = Path("./generated")

def load_yaml(path: Path):
	data = {}
	with path.open("r") as f:
		data = yaml.load(f, Loader=yaml.Loader)
	return data

def save_file(data: str, path: Path):
	path.write_text(data)

def render_string(templatedText: str, variables: dict):
	template = Template(templatedText)
	renderedText = template.render(**variables)
	return renderedText

def clean(path: Path):
	if(path.exists()):
		print(f"Deleting {path}")
		shutil.rmtree(path)

def render_file(template_path: Path, out_path: Path, variables: dict):
	template_text = template_path.read_text()
	rendered_text = render_string(template_text, variables)

	print(f"Creating {out_path}")
	directory = os.path.dirname(out_path)
	if(not os.path.exists(directory)):
		os.makedirs(directory)
	out_path.write_text(rendered_text)

def render_cs(variables: dict):
	"""
	Expecting variable to have a "constant" key
	"""
	render_file(
		template_path=Path(SOURCE_PATH, "cs/csproj.j2"),
		out_path=Path(GENERATED_PATH, f"cs/{variables['projectName']}.csproj"),
		variables=variables,
	)
	render_file(
		template_path=Path(SOURCE_PATH, "cs/code.j2"),
		out_path=Path(GENERATED_PATH, f"cs/Constants.cs"),
		variables=variables,
	)

def render_python(variables: dict):
	"""
	Expecting variable to have a "constant" key
	"""
	def write_module(variables: dict, parent=""):
		render_file(
			template_path=Path(SOURCE_PATH, "python/code.j2"),
			out_path=Path(GENERATED_PATH, "python/constants", parent, "__init__.py"),
			variables=variables,
		)

		for name, value in variables["constants"].items():
			if(type(value) is dict):
				write_module({"constants":value, **meta}, parent=Path(parent, name))
	
	write_module(variables)

if(__name__ == '__main__'):

	start_time = datetime.now()

	clean(GENERATED_PATH)

	print(f"Loading constants.yaml")
	constants = load_yaml(Path("./constants.yaml"))

	print(f"Loading meta.yaml")
	meta = load_yaml(Path("./meta.yaml"))

	variables = {"constants":constants, **meta}

	print("Rendering C#")
	render_cs(variables)
	print("Rendering python")
	render_python(variables)

	print(f"Done! It took {datetime.now()-start_time} to complete.")
