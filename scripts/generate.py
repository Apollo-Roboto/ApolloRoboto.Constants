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
	# with path.open("w") as f:
	# 	f.write(data)

def render_string(templatedText: str, variables: dict):
	template = Template(templatedText)
	renderedText = template.render(**variables)
	return renderedText

def clean():
	if(GENERATED_PATH.exists()):
		print(f"Deleting {GENERATED_PATH}")
		shutil.rmtree(GENERATED_PATH)

def cs_render_csproj(template_path: Path, out_path: Path, variables: dict):
	template_text = template_path.read_text()
	rendered_text = render_string(template_text, variables)

	print(f"Creating {out_path}")
	directory = os.path.dirname(out_path)
	if(not os.path.exists(directory)):
		os.makedirs(directory)
	out_path.write_text(rendered_text)

def cs_render_code(template_path: Path, out_path: Path, variables: dict):
	template_text = template_path.read_text()
	rendered_text = render_string(template_text, variables)

	print(f"Creating {out_path}")
	directory = os.path.dirname(out_path)
	if(not os.path.exists(directory)):
		os.makedirs(directory)
	out_path.write_text(rendered_text)

def custom_function():
	return "// this is a test"


if(__name__ == '__main__'):

	clean()

	print(f"Loading constants.yaml")
	constants = load_yaml(Path("./constants.yaml"))

	print(f"Loading meta.yaml")
	meta = load_yaml(Path("./meta.yaml"))

	variables = {"constants":constants, **meta}

	cs_render_csproj(
		template_path=Path(SOURCE_PATH, "cs/csproj_template.j2"),
		out_path=Path(GENERATED_PATH, f"cs/{variables['projectName']}.csproj"),
		variables=variables,
	)

	cs_render_code(
		template_path=Path(SOURCE_PATH, "cs/code_template.j2"),
		out_path=Path(GENERATED_PATH, f"cs/Constants.cs"),
		variables=variables,
	)
